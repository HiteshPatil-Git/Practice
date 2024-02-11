namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; }
        IResultRepository ResultRepository { get; }
        IImageRepository ImageRepository { get; }
        IAdminRepository AdminRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
