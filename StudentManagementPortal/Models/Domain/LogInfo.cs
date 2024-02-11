namespace StudentManagementPortal.Models.Domain
{
    public class LogInfo
    {
        public int Id { get; set; }
        public DateTime LogTime { get; set; }
        public string Detail { get; set; }
        public string Type { get; set; }        
        public int UserId { get; set; }
    }
}
