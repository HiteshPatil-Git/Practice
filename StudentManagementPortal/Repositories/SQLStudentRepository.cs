using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StudentManagementPortal.Data;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;
using System.Text;

namespace StudentManagementPortal.Repositories
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly StudentPortalDbContext dbContext;

        public SQLStudentRepository(StudentPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public async Task<Student?> CreateAsync(Student student)
        {
            await dbContext.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return student;
        }

        
        public async Task<List<Student>> GetAllAsync()
        {
            //return await dbContext.Students.Include(s => s.Results).ThenInclude(r => r.ResultSubjects).ToListAsync(); //Retrives Results
            return await dbContext.Students.ToListAsync();
        }

        public async Task<Student?> GetStudentByEnrollmentIdAsync(int enrollmentId)
        {
            return await dbContext.Students.FirstOrDefaultAsync(s => s.EnrollmentId == enrollmentId);
        }

        public async Task<Student?> UpdateAsync(Student student, bool isStudent)
        {
            var existingStudent = await dbContext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
            if (existingStudent == null)
            {
                return null;
            }

            existingStudent.Name = student.Name.IsNullOrEmpty() ? existingStudent.Name : student.Name;
            existingStudent.Email = student.Email.IsNullOrEmpty() ? existingStudent.Email : student.Email;
            existingStudent.MobNumber = student.MobNumber.IsNullOrEmpty() ? existingStudent.MobNumber : student.MobNumber;
            existingStudent.ImageUrl = student.ImageUrl.IsNullOrEmpty() ? existingStudent.ImageUrl : student.ImageUrl;
            if (!isStudent)
            {
                existingStudent.Status = student.Status.IsNullOrEmpty() ? existingStudent.Status : student.Status;
            }

            await dbContext.SaveChangesAsync();
            return existingStudent;
        }


        public async Task<Student?> DeleteAsync(int enrollmentId)
        {
            var existingStudent = await dbContext.Students.FirstOrDefaultAsync(s => s.EnrollmentId == enrollmentId);
            if (existingStudent == null)
            {
                return null;
            }
            dbContext.Remove(existingStudent);
            await dbContext.SaveChangesAsync();
            return existingStudent;
        }
    }
}
