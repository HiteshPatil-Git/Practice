using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.Data;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace StudentManagementPortal.Repositories
{
    public class SQLLoggerRepository : ILoggerRepository
    {
        private readonly StudentPortalDbContext dbContext;

        public SQLLoggerRepository(StudentPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<LogInfo> CreateAsync(LogInfo logInfo)
        {
            await dbContext.LogInfos.AddAsync(logInfo);
            await dbContext.SaveChangesAsync();
            return logInfo;
        }

        public async Task<LogInfo?> GetById(int id)
        {
            return await dbContext.LogInfos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LogInfo?> GetByUserId(int userId)
        {
            return await dbContext.LogInfos.OrderByDescending(x => x.LogTime).FirstOrDefaultAsync(x => x.UserId ==  userId);
        }
    }
}
