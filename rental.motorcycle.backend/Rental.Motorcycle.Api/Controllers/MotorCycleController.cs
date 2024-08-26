using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rental.MotorCycle.Application.Request;
using System.Text.Json;

namespace Rental.Motorcycle.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotorCycleController : ControllerBase
    {
        private readonly ILogger<MotorCycleController> _logger;

        public MotorCycleController(ILogger<MotorCycleController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Post(AddMotorCycleRequest request)
        {
            const string message = "MotorCycle-Post";
            var guid = Guid.NewGuid().ToString();

            _logger.LogTrace(message: message, JsonSerializer.Serialize(request), guid);

            try
            {

                return null;
            }
            finally
            {
                _logger.LogTrace(message: message, guid);
            }
        }

        [HttpPut]
        [Authorize(Roles = "admin")]
        public IActionResult Put(UpdateMotorCycleRequest request)
        {
            const string message = "MotorCycle-Put";
            var guid = Guid.NewGuid().ToString();

            _logger.LogTrace(message: message, JsonSerializer.Serialize(request), guid);

            try
            {

                return null;
            }
            finally
            {
                _logger.LogTrace(message: message, guid);
            }
        }


        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Get(string? plate)
        {
            const string message = "MotorCycle-Get";
            var guid = Guid.NewGuid().ToString();

            _logger.LogTrace(message: message, JsonSerializer.Serialize(plate), guid);

            try
            {

                return null;
            }
            finally
            {
                _logger.LogTrace(message: message, guid);
            }
        }


        [HttpDelete]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(Guid Id)
        {
            const string message = "MotorCycle-Delete";
            var guid = Guid.NewGuid().ToString();

            _logger.LogTrace(message: message, JsonSerializer.Serialize(Id), guid);

            try
            {

                return null;
            }
            finally
            {
                _logger.LogTrace(message: message, guid);
            }
        }

    }
}
