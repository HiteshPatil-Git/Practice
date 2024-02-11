using StudentManagementPortal.Models.Domain;

namespace StudentManagementPortal.Models.DTOs
{
    public class ResultDto
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public int TotalObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
        public bool IsPass { get; set; }
        public int StudentId { get; set; }

        public StudentProfileDto Student { get; set; }

        public List<ResultSubjectDto> ResultSubjects { get; set; }
    }
}
