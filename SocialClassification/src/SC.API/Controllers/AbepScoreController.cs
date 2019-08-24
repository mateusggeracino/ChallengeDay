using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SC.Services.Interfaces;

namespace SC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbepScoreController : ControllerBase
    {
        private readonly ILogger<AbepScoreController> _logger;
        private readonly IScoreServices _scoreServices;

        public AbepScoreController(ILogger<AbepScoreController> logger, IScoreServices scoreServices)
        {
            _logger = logger;
            _scoreServices = scoreServices;
        }

        [HttpGet]
        public ActionResult<string> Get([FromHeader] int clientId)
        {
            try
            {
                _logger.LogInformation("Get score client");
                var result = _scoreServices.GetScoreClient(clientId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}