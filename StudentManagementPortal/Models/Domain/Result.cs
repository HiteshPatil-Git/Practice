namespace StudentManagementPortal.Models.Domain
{
    public class Result
    {
        public int Id { get; set; }
        public string Year { get; set; } //2023-2024

        public int TotalObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
        public bool IsPass { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public ICollection<ResultSubject> ResultSubjects { get; set; }

    }
}
