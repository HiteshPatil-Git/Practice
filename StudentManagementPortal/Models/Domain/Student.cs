using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementPortal.Models.Domain
{
    public class Student : User
    {

        public int EnrollmentId { get; set; }
        public string? ImageUrl { get; set; }
        public string? MobNumber { get; set; }
        
        [NotMapped]
        public IFormFile File { get; set; }


        public ICollection<Result> Results { get; set; }

        
    }
}
