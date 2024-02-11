using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface ILoggerRepository
    {
        Task<LogInfo> CreateAsync(LogInfo logInfo);
        Task<LogInfo?> GetById(int id);
        Task<LogInfo?> GetByUserId(int userId);
    }
}
