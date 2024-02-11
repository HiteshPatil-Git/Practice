namespace StudentManagementPortal.Models.DTOs
{
    public class AdminDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

        public string Level { get; set; }
    }
}
