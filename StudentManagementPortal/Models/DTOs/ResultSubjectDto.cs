using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Models.DTOs
{
    public class ResultSubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
        public bool IsPass { get; set; }
        public int ResultId { get; set; }
        
    }
}
