using DemansAppWebApi.Entities;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("~/api/[controller]")]
        public async Task<ActionResult<IEnumerable<Users>>> GetAllUsersAsync()
        {
            try
            {
                var users = await _usersService.GetAllUsersAsync();
                return Ok(new ResponseModel { message = "Success", data = users });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpPost("~/api/[controller]")]
        public async Task<IActionResult> AddUser([FromBody] Users users)
        {
            await _usersService.AddUserAsync(users);
            return Ok(new ResponseModel { message = "Success", data = users });
        }

    }
}
