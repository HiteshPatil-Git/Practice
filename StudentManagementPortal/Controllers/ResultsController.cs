using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;
using StudentManagementPortal.Repositories.Interfaces;
using System.Net;
using System.Security.Claims;
using Azure;
using static System.Net.Mime.MediaTypeNames;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using StudentManagementPortal.Services.Interfaces;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace StudentManagementPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IResultService resultService;

        public ResultsController(IMapper mapper, IResultService resultService)
        {
            this.mapper = mapper;
            this.resultService = resultService;
        }

        //Create, GetById & GeneratePdf returns PDF file in response

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] AddResultRequestDto addResultRequestDto)
        {
            var response = await resultService.CreateAsync(addResultRequestDto);
            if (response != null)
            {
                var filecontentResult = new FileContentResult(response, "application/octet-stream")
                {
                    FileDownloadName = "Result.pdf"
                };
                return filecontentResult;
            }
            return BadRequest(new ApiErrorResponse(HttpStatusCode.BadRequest, $"Result data not saved!"));
        }



        [HttpGet]
        [Route("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await resultService.GetByIdAsync(id);
            if (response != null)
            {
                //return File(dataBytes, "application/pdf");
                var filecontentResult = new FileContentResult(response, "application/octet-stream")
                {
                    FileDownloadName = "Result.pdf"
                };
                return filecontentResult;
            }
            throw new Exception("Failed to generate PDF!");
        }


        [HttpGet]
        [Route("GeneratePdf/{id:int}")]
        public async Task<ActionResult> GeneratePdf([FromRoute] int id)
        {

            var response = await resultService.GetByIdAsync(id);
            if (response != null)
            {
                //return File(dataBytes, "application/pdf");

                var filecontentResult = new FileContentResult(response, "application/octet-stream")
                {
                    FileDownloadName = "Result.pdf"
                };
                return filecontentResult;
            }
            throw new Exception("Failed to generate PDF!");
        }


        //GetAll, ByLoggedUser, ByEnrollmentId returns Data
        [HttpGet]
        [Route("ByLoggedUser")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> GetByLoggedUser()
        {
            int enrollmentId = Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.SerialNumber));

            var resultList = await resultService.GetByEnrollmentIdAsync(enrollmentId);

            return Ok(mapper.Map<List<ResultDto>>(resultList));
        }



        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var resultList = await resultService.GetAllAsync();
            var resultListDto = mapper.Map<List<ResultDto>>(resultList);
            return Ok(resultListDto);
        }


        [HttpGet]
        [Route("EnrollmentId/{enrollmentId:int}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetByEnrollmentId([FromRoute] int enrollmentId)
        {
            var resultList = await resultService.GetByEnrollmentIdAsync(enrollmentId);

            return Ok(mapper.Map<List<ResultDto>>(resultList));
        }


    }
}
