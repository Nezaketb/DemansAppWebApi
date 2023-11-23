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

        [HttpGet("~/api/[controller]")]
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

        [HttpGet("~/api/[controller]/{userId}")]
        public async Task<ActionResult<LocationInformation>> GetLocationsByUserId(int userId)
        {
            try
            {
                var store = await _locationInformationService.GetLocationsByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = store });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}
