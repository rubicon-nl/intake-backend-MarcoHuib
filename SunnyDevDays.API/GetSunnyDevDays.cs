using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SunnyDevDays.API
{
    public class GetSunnyDevDays
    {
        private readonly ILogger<GetSunnyDevDays> _logger;

        public GetSunnyDevDays(ILogger<GetSunnyDevDays> logger)
        {
            _logger = logger;
        }

        [Function("GetSunnyDevDays")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {
            return new OkResult();
        }
    }
}
