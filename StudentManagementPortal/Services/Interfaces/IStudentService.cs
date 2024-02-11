using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;

namespace StudentManagementPortal.Services.Interfaces
{
    public interface IStudentService
    {
        public Task<Student?> CreateAsync(AddStudentRequestDto addStudentRequestDto);

        Task<Student> GetStudentByEnrollmentIdAsync(int enrollmentId);
        Task<Student> UpdateAsync(Student student);

        Task<List<Student>> GetAllAsync();
        Task<Student?> DeleteAsync(int enrollmentId);
    }
}
