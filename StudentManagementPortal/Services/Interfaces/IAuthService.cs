using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Services.Interfaces
{
    public interface IAuthService
    {
        string GetHashedPassword(string password);

        string CreateJWTToken(User user);

        bool VerifyHashedPassword(string password, string userHashedPass);
    }
}
