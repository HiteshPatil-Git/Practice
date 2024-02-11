using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface ITokenHandler
    {
        string CreateJWTToken(User user);
    }
}
