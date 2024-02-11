using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Models.DTOs
{
    public class AddUserRequestDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public int? EnrollmentId { get; set; }
        public string? ImageUrl { get; set; }
        public string? MobNumber { get; set; }

        public string? Level { get; set; }
    }
}
