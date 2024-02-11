using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface IImageRepository
    {
        Task<Image?> UploadAsync(IFormFile file, int studentId);
        Task<Image?> UpdateAsync(IFormFile file, int studentId);
        Task<Image?> GetByIdAsync(int id);
        Task<Image?> GetByStudentIdAsync(int studentId);
    }
}
