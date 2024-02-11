using Microsoft.IdentityModel.Tokens;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace StudentManagementPortal.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IConfiguration configuration;

        public AuthRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetHashedPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltLength = Convert.ToInt32(configuration["Jwt:SaltLength"]);
                var saltOptions = configuration["Jwt:SaltOptions"];
                var salt = new StringBuilder();
                for (int i = 0; i < saltLength; i++)
                {
                    salt.Append(saltOptions.Substring(new Random().Next(0, 61), 1));
                }
                var saltString = salt.ToString();
                password = password + saltString;

                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return (string)(BitConverter.ToString(hashedBytes).Replace("-", "").ToLower()) + saltString;
            }
        }

        public bool VerifyHashedPassword(string password, string userHashedPass)
        {
            using (var sha256 = SHA256.Create())
            {
                string saltString = userHashedPass.Substring(userHashedPass.Length - Convert.ToInt32(configuration["Jwt:SaltLength"]));
                password = password + saltString;
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                var hashTobeValidated = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower() + saltString;
                return (hashTobeValidated.Equals(userHashedPass)) ? true : false;
            }
        }

        public string CreateJWTToken(User user)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            if (user.Role == "Student")
            {
                Student student = (Student)user;
                claims.Add(new Claim(ClaimTypes.SerialNumber, student.EnrollmentId.ToString()));
            }
            claims.Add(new Claim(ClaimTypes.Sid, user.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Role, user.Role));
            claims.Add(new Claim(ClaimTypes.Name, user.Name));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configuration["Jwt:Issuer"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(50),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
