using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;
using StudentManagementPortal.Repositories.Interfaces;
using StudentManagementPortal.Services.Interfaces;
using System.Net;
using System.Security.Claims;

namespace StudentManagementPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IStudentService studentService;

        public StudentsController(IMapper mapper, IStudentService studentService)
        {
            this.mapper = mapper;
            this.studentService = studentService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var studentList = await studentService.GetAllAsync();
            return Ok(mapper.Map<List<StudentProfileDto>>(studentList));
        }


        [HttpGet]
        [Route("{enrollmentId:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetStudentProfile([FromRoute] int enrollmentId)
        {
            var student = await studentService.GetStudentByEnrollmentIdAsync(enrollmentId);
            return Ok(mapper.Map<StudentProfileDto>(student));
        }


        [HttpGet]
        [Route("MyProfile")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> GetByLoggedUser()
        {
            int enrollmentId = Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.SerialNumber));
            var student = await studentService.GetStudentByEnrollmentIdAsync(enrollmentId);
            return Ok(mapper.Map<StudentProfileDto>(student));
        }


        [HttpPut]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> UpdateStudentProfile([FromForm] UpdateStudentRequestDto updateStudentRequestDto)
        {
            var student = mapper.Map<Student>(updateStudentRequestDto);

            student = await studentService.UpdateAsync(student);

            return Ok(mapper.Map<StudentProfileDto>(student));
        }


        [HttpPut]
        [Authorize(Roles = "Admin")]
        [Route("ByAdmin")]
        public async Task<IActionResult> UpdateStudentProfileByAdmin([FromForm] UpdateStudentByAdminRequestDto updateStudentByAdminRequestDto)
        {

            var student = mapper.Map<Student>(updateStudentByAdminRequestDto);

            student = await studentService.UpdateAsync(student);

            return Ok(mapper.Map<StudentProfileDto>(student));
        }


        [HttpDelete]
        [Route("{enrollmentId:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] int enrollmentId)
        {
            var deletedStudent = await studentService.DeleteAsync(enrollmentId);
            return Ok(mapper.Map<StudentProfileDto>(deletedStudent));
        }
    }
}
