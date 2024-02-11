namespace StudentManagementPortal.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }      //Active-Locked-Deactivate

        //public int? StudentId { get; set; }

        //public Student? Student { get; set; }


    }
}
