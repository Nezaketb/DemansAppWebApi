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

        [HttpGet("~/api/[controller]")]
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

        [HttpGet("~/api/[controller]/{userId}")]
        public async Task<ActionResult<Medicines>> GetMedicinesByUserId(int userId)
        {
            try
            {
                var medicines = await _medicinesService.GetMedicinesByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = medicines });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}
