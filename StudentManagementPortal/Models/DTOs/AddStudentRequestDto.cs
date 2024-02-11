using System.ComponentModel.DataAnnotations;
using System.Net;

namespace StudentManagementPortal.Models.DTOs
{
    public class AddStudentRequestDto
    {

        [Required]
        public string Name { get; set; }


        [Required]
        [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<>()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter valid email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [DataType(DataType.Password, ErrorMessage = "Please enter valid password!")]
        public string Password { get; set; }

        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please enter valid enrollmentId!")]
        public int EnrollmentId { get; set; }
        public IFormFile? File { get; set; }

        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile number must be numeric and 10 digits!")]
        public string? MobNumber { get; set; }



    }
}
