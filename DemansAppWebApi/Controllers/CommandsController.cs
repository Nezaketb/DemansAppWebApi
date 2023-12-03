using DemansAppWebApi.Entities;
using DemansAppWebApi.Services;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class CommandsController : Controller
    {
        private readonly ICommandsService _commandsService;

        public CommandsController(ICommandsService commandsService)
        {
            _commandsService = commandsService;
        }

        [HttpGet("~/api/[controller]")]
        public async Task<ActionResult<IEnumerable<Commands>>> GetAllCommandsAsync()
        {
            try
            {
                var commands = await _commandsService.GetAllCommandsAsync();
                return Ok(new ResponseModel { message = "Success", data = commands });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<Commands>> GetCommandsByUserId(int userId)
        {
            try
            {
                var commands = await _commandsService.GetCommandsByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = commands });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpPost("~/api/[controller]")]
        public async Task<IActionResult> AddCommand([FromBody] Commands command)
        {
            try
            {
                await _commandsService.AddCommandAsync(command);
                return Ok(new ResponseModel { message = "Success", data = command });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}
