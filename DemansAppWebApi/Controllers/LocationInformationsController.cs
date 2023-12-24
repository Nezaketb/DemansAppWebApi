using DemansAppWebApi.Entities;
using DemansAppWebApi.Services;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class LocationInformationsController : Controller
    {
        private readonly ILocationInformationService _locationInformationService;

        public LocationInformationsController(ILocationInformationService locationInformationService)
        {
            _locationInformationService = locationInformationService;
        }

        [HttpGet("~/api/[controller]/getAllLocation")]
        public async Task<ActionResult<IEnumerable<LocationInformation>>> GetAllLocationAsync()
        {
            try
            {
                var locations = await _locationInformationService.GetAllLocationInformationAsync();
                return Ok(new ResponseModel { message = "Success", data = locations });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpGet("~/api/[controller]/getLocation/{userId}")]
        public async Task<ActionResult<LocationInformation>> GetLocationsByUserId(int userId)
        {
            try
            {
                var location = await _locationInformationService.GetLocationsByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = location });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpPost("~/api/[controller]/addLocation")]
        public async Task<IActionResult> AddLocation([FromBody] LocationInformation location)
        {
            try
            {
                await _locationInformationService.AddLocationAsync(location);
                return Ok(new ResponseModel { message = "Success", data = location });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}
