using StudentManagementPortal.Data;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;

namespace StudentManagementPortal.Repositories
{
    public class SQLAdminRepository : IAdminRepository
    {
        private readonly StudentPortalDbContext dbContext;

        public SQLAdminRepository(StudentPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Admin> CreateAsync(Admin admin)
        {
            await dbContext.AddAsync(admin);
            await dbContext.SaveChangesAsync();
            return admin;
        }
    }
}
