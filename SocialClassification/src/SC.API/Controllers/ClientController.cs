using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SC.API.Controllers.Base;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Request;

namespace SC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseController
    {
        private readonly IClientServices _clientServices;
        private readonly ILogger<ClientController> _logger;

        public ClientController(IClientServices clientServices, ILogger<ClientController> logger)
        {
            _clientServices = clientServices;
            _logger = logger;
        }

        
        [HttpPost]
        public ActionResult<string> Post([FromBody] ClientRequestViewModel client)
        {
            try
            {
                _logger.LogInformation("Add a new client");
                var result = _clientServices.Add(client);
                if (result.ValidationResult.Errors.Any()) return AddValidationErrors(result.ValidationResult.Errors);

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