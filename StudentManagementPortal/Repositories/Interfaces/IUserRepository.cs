using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> FindByEmailAsync(string email);

    }
}
