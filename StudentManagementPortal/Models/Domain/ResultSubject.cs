namespace StudentManagementPortal.Models.Domain
{
    public class ResultSubject
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int ObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
        public bool IsPass { get; set; }


        public int ResultId { get; set; }
        public Result Result { get; set; }


    }
}
