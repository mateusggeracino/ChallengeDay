using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Request;

namespace SC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwsnerController : ControllerBase
    {
        private readonly ILogger<AwsnerController> _logger;
        private readonly IAwsnerServices _awsnerServices;

        public AwsnerController(ILogger<AwsnerController> logger, IAwsnerServices awsnerServices)
        {
            _logger = logger;
            _awsnerServices = awsnerServices;
        }

        [HttpPost]
        public ActionResult<string> Post([FromHeader] int clientId, [FromBody] IEnumerable<AwsnerRequestViewModel> awsner)
        {
            try
            {
                _logger.LogInformation("Post awsner");
                _awsnerServices.Add(clientId, awsner);

                return Ok("success");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}