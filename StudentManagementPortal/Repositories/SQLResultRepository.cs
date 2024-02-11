using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.Data;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;

namespace StudentManagementPortal.Repositories
{
    public class SQLResultRepository : IResultRepository
    {
        private readonly StudentPortalDbContext dbContext;

        public SQLResultRepository(StudentPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Result> CreateAsync(Result result)
        {
            await dbContext.Results.AddAsync(result);
            await dbContext.SaveChangesAsync();
            return result;

        }

        public async Task<List<Result>> GetAllAsync()
        {
            return await dbContext.Results.Include(r => r.Student).Include(r => r.ResultSubjects).ToListAsync();
        }

        public async Task<List<Result>?> GetByEnrollmentIdAsync(int enrollmentId)
        {
            return await dbContext.Results.Include(r => r.Student).Include(r => r.ResultSubjects).Where(r => r.Student.EnrollmentId == enrollmentId).ToListAsync(); ;
        }

        public async Task<Result?> GetByIdAsync(int id)
        {

            var result = await dbContext.Results.Include(r => r.Student).Include(r => r.ResultSubjects).FirstOrDefaultAsync(r => r.Id == id);
            if (result == null)
            {
                return null;
            }
            return result;
        }


    }
}
