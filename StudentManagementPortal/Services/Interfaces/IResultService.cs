using Microsoft.AspNetCore.Mvc;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;

namespace StudentManagementPortal.Services.Interfaces
{
    public interface IResultService
    {
        Task<byte[]> CreateAsync(AddResultRequestDto addResultRequestDto);
        Task<byte[]> GetByIdAsync(int id);
        Task<List<Result>> GetByEnrollmentIdAsync(int enrollmentId);
        Task<List<Result>> GetAllAsync();
    }
}
