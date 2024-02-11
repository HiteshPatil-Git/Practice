using AutoMapper;
using EntityFramework.Exceptions.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.CustomeActionFilter;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;
using StudentManagementPortal.Repositories.Interfaces;
using StudentManagementPortal.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace StudentManagementPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        private readonly IAuthService authService;
        private readonly IStudentService studentService;
        private readonly ILoggerService loggerService;

        public AuthController(IUserService userService, IMapper mapper, IAuthService authService, IStudentService studentService, ILoggerService loggerService)
        {
            this.userService = userService;
            this.mapper = mapper;
            this.authService = authService;
            this.studentService = studentService;
            this.loggerService = loggerService;
        }




        [HttpPost]
        [Route("Register")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Register([FromForm] AddStudentRequestDto addStudentRequestDto)
        {
            var student = await studentService.CreateAsync(addStudentRequestDto);

            return Ok(mapper.Map<StudentProfileDto>(student));
        }



        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var user = await userService.FindByEmailAsync(loginRequestDto.Email);
            if (user == null)
            {
                return BadRequest(new ApiErrorResponse(HttpStatusCode.BadRequest, "Email incorrect!"));
            }
            if (user.Status == "Active")
            {
                var isValid = authService.VerifyHashedPassword(loginRequestDto.Password, user.HashPassword);
                if (isValid)
                {
                    //Generate Token
                    var token = authService.CreateJWTToken(user);
                    return Ok(new ApiErrorResponse(HttpStatusCode.OK, token));
                }
                else
                {
                    LogInfo logInfo = await loggerService.CreateAsync(user);
                    return BadRequest(new ApiErrorResponse(HttpStatusCode.BadRequest, $"Password Incorrect! {logInfo.Type} of 3 attemps!!!"));
                }
            }
            return BadRequest(new ApiErrorResponse(HttpStatusCode.Locked, "User is Locked!"));
        }

    }
}
