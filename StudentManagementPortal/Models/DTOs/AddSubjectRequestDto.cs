using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementPortal.Models.DTOs
{
    public class AddSubjectRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int ObtainedMarks { get; set; }
        [Required]
        public int TotalMarks { get; set; }

        

    }
}
