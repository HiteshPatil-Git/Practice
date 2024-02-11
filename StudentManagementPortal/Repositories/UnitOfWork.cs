using Microsoft.EntityFrameworkCore.Storage;
using StudentManagementPortal.Data;
using StudentManagementPortal.Repositories.Interfaces;

namespace StudentManagementPortal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IServiceProvider serviceProvider;
        private readonly StudentPortalDbContext dbContext;
        private IDbContextTransaction transaction;

        public UnitOfWork(IServiceProvider serviceProvider, StudentPortalDbContext dbContext)
        {
            this.serviceProvider = serviceProvider;
            this.dbContext = dbContext;
            StudentRepository = serviceProvider.GetRequiredService<IStudentRepository>();
            AdminRepository = serviceProvider.GetRequiredService<IAdminRepository>();
            ResultRepository = serviceProvider.GetRequiredService<IResultRepository>();
            ImageRepository = serviceProvider.GetRequiredService<IImageRepository>();

        }
        public IStudentRepository StudentRepository { get; }

        public IResultRepository ResultRepository { get; }

        public IImageRepository ImageRepository { get; }

        public IAdminRepository AdminRepository { get; }

        public void BeginTransaction()
        {
            transaction = dbContext.Database.BeginTransaction();
        }

        public async void Commit()
        {
            try
            {
                await dbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception)
            {

                Rollback();
            }
        }


        public async void Rollback()
        {
            await transaction.RollbackAsync();
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
        public async void Dispose()
        {
            await dbContext.DisposeAsync();
        }
    }
}
