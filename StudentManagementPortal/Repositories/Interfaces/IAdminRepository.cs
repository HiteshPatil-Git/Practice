using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        Task<Admin> CreateAsync(Admin admin);
    }
}
