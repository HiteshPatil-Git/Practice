using System.Net;

namespace StudentManagementPortal.Models.DTOs
{
    public class ApiErrorResponse
    {
        public ApiErrorResponse(HttpStatusCode code, string message)
        {
            Id = Guid.NewGuid();
            Code = code;
            Message = message;
            
        }

        public Guid Id { get; set; }
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        
    }
}
