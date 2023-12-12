using DemansAppWebApi.Entities;
using DemansAppWebApi.Services;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class MedicinesController : Controller
    {
        private readonly IMedicinesService _medicinesService;

        public MedicinesController(IMedicinesService medicinesService)
        {
            _medicinesService = medicinesService;
        }

        [HttpGet("~/api/[controller]/getAllMedicines")]
        public async Task<ActionResult<IEnumerable<Medicines>>> GetAllMedicinesAsync()
        {
            try
            {
                var medicines = await _medicinesService.GetAllMedicinesAsync();
                return Ok(new ResponseModel { message = "Success", data = medicines });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpGet("~/api/[controller]/getMedicines/{userId}")]
        public async Task<ActionResult<Companions>> GetMedicinesByUserId(int userId)
        {
            try
            {
                var companion = await _medicinesService.GetMedicinesByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = companion });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
        [HttpPost("~/api/[controller]/addMedicine")]
        public async Task<IActionResult> AddMedcine([FromBody] Medicines medicine)
        {
            try
            {
                await _medicinesService.AddMedicineAsync(medicine);
                return Ok(new ResponseModel { message = "Success", data = medicine });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}
