using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;

namespace StudentManagementPortal.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student?> CreateAsync(Student student);
        Task<Student?> GetStudentByEnrollmentIdAsync(int enrollmentId);
        Task<Student?> UpdateAsync(Student student, bool isStudent = true);

        Task<List<Student>> GetAllAsync();
        Task<Student?> DeleteAsync(int enrollmentId);
    }
}
