namespace StudentManagementPortal.Models.Domain
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
