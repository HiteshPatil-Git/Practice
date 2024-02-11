using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface IResultRepository
    {
        Task<Result> CreateAsync(Result result);
        Task<List<Result>> GetAllAsync();
        Task<Result?> GetByIdAsync(int id);
        Task<List<Result>?> GetByEnrollmentIdAsync(int enrollmentId);
        
    }
}
