using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;
using StudentManagementPortal.Services.Interfaces;

namespace StudentManagementPortal.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILoggerRepository loggerRepository;

        public LoggerService(ILoggerRepository loggerRepository)
        {
            this.loggerRepository = loggerRepository;
        }
        public async Task<LogInfo> CreateAsync(User user)
        {

            LogInfo logInfo = await loggerRepository.GetByUserId(user.Id);
            var newLogInfo = new LogInfo();
            if (logInfo == null)
            {
                newLogInfo.Type = "Password Fail-1";
            }
            else
            {
                var attemptIndex = Convert.ToInt32(logInfo.Type.IndexOf('-'))+1;
                var attemptCount = Convert.ToInt32(logInfo.Type.Substring(attemptIndex)) + 1;
                newLogInfo.Type = $"{logInfo.Type.Substring(0, attemptIndex)}{ attemptCount}";
                if (attemptCount == 3)
                {

                }
            }
            newLogInfo.Detail = $"Password fail-attempt by {user.Id}";
            newLogInfo.LogTime = DateTime.Now;
            newLogInfo.UserId = user.Id;


            return await loggerRepository.CreateAsync(newLogInfo);
        }

    }
}
