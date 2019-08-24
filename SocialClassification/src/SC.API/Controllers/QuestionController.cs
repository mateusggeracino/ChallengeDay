using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SC.API.Controllers.Base;
using SC.Services.Interfaces;

namespace SC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : BaseController
    {
        private readonly ILogger<QuestionController> _logger;
        private readonly IQuestionServices _questionServices;

        public QuestionController(ILogger<QuestionController> logger, IQuestionServices questionServices)
        {
            _logger = logger;
            _questionServices = questionServices;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            try
            {
                _logger.LogInformation("get all questions");
                var result = _questionServices.GetAll();
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