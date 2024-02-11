using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Services.Interfaces
{
    public interface ILoggerService
    {
        Task<LogInfo> CreateAsync(User user);
    }
}
