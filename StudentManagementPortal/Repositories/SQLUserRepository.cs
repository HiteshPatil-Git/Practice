using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.Data;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;
using StudentManagementPortal.Repositories.Interfaces;

namespace StudentManagementPortal.Repositories
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly StudentPortalDbContext dbContext;

        public SQLUserRepository(StudentPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        public async Task<User?> FindByEmailAsync(string email)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }


    }
}
