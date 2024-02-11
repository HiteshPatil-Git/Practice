using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc;
using StudentManagementPortal.Repositories.Interfaces;
using StudentManagementPortal.Services.Interfaces;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using iText.Layout;
using StudentManagementPortal.Models.Domain;
using AutoMapper;
using StudentManagementPortal.Models.DTOs;
using System.Net;
using Microsoft.AspNetCore.SignalR;
using Microsoft.IdentityModel.Tokens;

namespace StudentManagementPortal.Services
{
    public class ResultService : IResultService
    {
        private readonly IResultRepository resultRepository;
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public ResultService(IResultRepository resultRepository, IStudentRepository studentRepository, IMapper mapper)
        {
            this.resultRepository = resultRepository;
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }


        public async Task<byte[]> CreateAsync(AddResultRequestDto addResultRequestDto)
        {
            var student = await studentRepository.GetStudentByEnrollmentIdAsync(addResultRequestDto.EnrollmentId);
            if (student == null)
            {
                throw new BadHttpRequestException($"Invalid {addResultRequestDto.EnrollmentId} EnrollmentId!!");
            }

            var result = mapper.Map<Result>(addResultRequestDto);
            result.StudentId = student.Id;

            result = await resultRepository.CreateAsync(result);
            if (result == null)
            {
                throw new BadHttpRequestException($"Result not saved");
            }
            return GetResultByteData(result);
        }



        public async Task<byte[]> GetByIdAsync(int id)
        {
            var result = await resultRepository.GetByIdAsync(id);
            if (result == null)
            {
                throw new BadHttpRequestException($"Result not found for {id} Result-Id");
            }
            return GetResultByteData(result);
        }

        private static byte[] GetResultByteData(Result? result)
        {
            MemoryStream ms = new MemoryStream();
            var writer = new PdfWriter(ms);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            Paragraph newline = new Paragraph(new Text("\n"));
            LineSeparator lineSeparator = new LineSeparator(new SolidLine());

            Paragraph header = new Paragraph("RESULT")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(20);

            document.Add(header);
            document.Add(lineSeparator);

            Paragraph resultId = new Paragraph($"ResultId : {result.Id.ToString()}");
            Paragraph resultYear = new Paragraph($"Year : {result.Year}");
            Paragraph enrollmentId = new Paragraph($"EnrollmentId : {result.Student.EnrollmentId.ToString()}");
            Paragraph studentName = new Paragraph($"Student Name : {result.Student.Name}");
            document.Add(resultId);
            document.Add(resultYear);
            document.Add(enrollmentId);
            document.Add(studentName);
            Paragraph totalObtainedMarks = new Paragraph($"Obtained Marks : {result.TotalObtainedMarks}");
            Paragraph totalMarks = new Paragraph($"Total Marks : {result.TotalMarks}");

            Paragraph isPass = new Paragraph($"Result : {(result.IsPass ? $"Pass" : $"Fail")} ");
            document.Add(totalObtainedMarks);
            document.Add(totalMarks);
            document.Add(isPass);
            document.Add(new Paragraph($"Subjects : "));
            document.Add(lineSeparator);

            foreach (var sub in result.ResultSubjects)
            {

                Paragraph subject = new Paragraph($"{sub.Name} => Marks: {sub.ObtainedMarks}/{sub.TotalMarks} => {(sub.IsPass ? $"Pass" : $"Fail")} ");

                document.Add(subject);
            }
            document.Add(lineSeparator);

            document.Close();
            byte[] dataBytes = ms.ToArray();
            return dataBytes;
        }

        public async Task<List<Result>> GetByEnrollmentIdAsync(int enrollmentId)
        {
            var resultList = await resultRepository.GetByEnrollmentIdAsync(enrollmentId);
            if (resultList.IsNullOrEmpty())
            {
                throw new BadHttpRequestException($"Invalid {enrollmentId} EnrollmentId!!");
            }
            //mapper.Map<List<ResultDto>>(resultList);
            return resultList;
        }

        public async Task<List<Result>> GetAllAsync()
        {
            var resultList = await resultRepository.GetAllAsync();
            if (resultList.IsNullOrEmpty())
            {
                throw new BadHttpRequestException("Results not found");
            }
            
            return resultList;
        }
    }
}
