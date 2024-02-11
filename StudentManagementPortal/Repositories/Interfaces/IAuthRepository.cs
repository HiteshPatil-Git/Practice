using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        string GetHashedPassword(string password);

        string CreateJWTToken(User user);

        bool VerifyHashedPassword(string password, string userHashedPass);
    }
}
