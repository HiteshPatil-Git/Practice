using Microsoft.AspNetCore.Mvc;
using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Models.DTOs
{
    public class StudentDto
    {
        public int EnrollmentId { get; set; }
        public string ImageUrl { get; set; }
        public string MobNumber { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        
        public string Role { get; set; }
        public string Status { get; set; }

        public List<ResultDto> Results { get; set; }
    }
}
