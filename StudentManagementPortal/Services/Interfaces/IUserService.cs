using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> FindByEmailAsync(string email);
    }
}
