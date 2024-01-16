using DemansAppWebApi.Entities;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class PicturesController : Controller
    {
        private readonly IPictureService _picturesService;

        public PicturesController(IPictureService picturesService)
        {
            _picturesService = picturesService;
        }


        [HttpGet("~/api/[controller]/getPictures/{userId}")]
        public async Task<ActionResult<Pictures>> GetPicturesByUserId(int userId)
        {
            try
            {
                var picture = await _picturesService.GetPicturesByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = picture });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
        [HttpPost("~/api/[controller]/addPictures")]
        public async Task<IActionResult> AddPicture([FromBody] Pictures picture)
        {
            try
            {
                await _picturesService.AddPictureAsync(picture);
                return Ok(new ResponseModel { message = "Success", data = picture });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}
