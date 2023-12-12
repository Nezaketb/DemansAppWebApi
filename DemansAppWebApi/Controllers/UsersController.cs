using DemansAppWebApi.Entities;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("~/api/[controller]/getAllUsers")]
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

        [HttpPost("~/api/[controller]/addUser")]
        public async Task<IActionResult> AddUser([FromBody] Users users)
        {
            try
            {
                await _usersService.AddUserAsync(users);
                return Ok(new ResponseModel { message = "Success", data = users });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }


        [HttpPost("~/api/[controller]/UpdateUser")]
        public async Task<IActionResult> UpdateUserAsync([FromBody] Users model)
        {
            try
            {
                var isUpdated = await _usersService.UpdateUserAsync(model);

                if (isUpdated)
                {
                    return Ok(new ResponseModel { message = "User updated successfully." });
                }
                else
                {
                    return NotFound(new ResponseModel { message = "User not found or update failed." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

    }
}
