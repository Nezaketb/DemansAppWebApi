using DemansAppWebApi.Entities;
using DemansAppWebApi.Entities.Request;
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

        [HttpPost("~/api/[controller]/Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            try
            {
                await _usersService.RegisterAsync(request.UserName, request.Email, request.Password);
                return Ok(new { Message = "Kayıt başarılı" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpPost("~/api/[controller]/Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var isAuthenticated = await _usersService.AuthenticateAsync(request.Email, request.Password);

                if (isAuthenticated)
                {
                    return Ok(new { Message = "Giriş başarılı." });
                }
                else
                {
                    return Unauthorized(new { Message = "Geçersiz kullanıcı adı veya şifre." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}

