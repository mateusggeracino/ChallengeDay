using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Request;

namespace SC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly ILogger<AnswerController> _logger;
        private readonly IAnswerServices _answerServices;

        public AnswerController(ILogger<AnswerController> logger, IAnswerServices answerServices)
        {
            _logger = logger;
            _answerServices = answerServices;
        }

        [HttpPost]
        public ActionResult<string> Post([FromHeader] int clientId, [FromBody] IEnumerable<AnswerRequestViewModel> answer)
        {
            try
            {
                _logger.LogInformation("Post answer");
                _answerServices.Add(clientId, answer);

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