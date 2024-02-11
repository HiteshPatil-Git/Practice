using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Services.Interfaces
{
    public interface IImageService
    {
        Task<Image?> GetByStudentIdAsync(int  studentId);
    }
}
