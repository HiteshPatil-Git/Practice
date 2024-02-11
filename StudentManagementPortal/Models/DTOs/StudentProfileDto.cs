namespace StudentManagementPortal.Models.DTOs
{
    public class StudentProfileDto
    {
        public int EnrollmentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
        public string MobNumber { get; set; }
    }
}
