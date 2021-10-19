using LogApplication.Core.Logger;
using Microsoft.AspNetCore.Mvc;

namespace LogApplication.WebApi.Logger
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        readonly ILoggerService _loggerService;
        public LoggerController(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        [HttpPost("logger")]
        public bool PostInventoryAdjustment(LogInformationDto logInfo)
        {
            _loggerService.LogMessage(logInfo.Message, logInfo.LogType);
            return true;
        }
    }
}
