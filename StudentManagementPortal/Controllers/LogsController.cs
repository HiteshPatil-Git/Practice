using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementPortal.Repositories.Interfaces;

namespace StudentManagementPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private readonly ILoggerRepository loggerRepository;

        public LogsController(ILoggerRepository loggerRepository)
        {
            this.loggerRepository = loggerRepository;
        }

        
    }
}
