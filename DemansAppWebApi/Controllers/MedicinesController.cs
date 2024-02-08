using DemansAppWebApi.Entities;
using DemansAppWebApi.Entities.Request;
using DemansAppWebApi.Services;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime;

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
        public async Task<ActionResult<Medicines>> GetMedicinesByUserId(int userId)
        {
            try
            {
                var medicine = await _medicinesService.GetMedicinesByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = medicine });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpGet("~/api/[controller]/getMedicinesNear")]

        public async Task<IActionResult> GetMedicinesNearExpiration()
        {
            try
            {
                DateTime currentDate = DateTime.Now;

                var medicines = await _medicinesService.GetMedicinesNearExpiration(currentDate);

                return Ok(medicines);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
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
        [HttpPost("~/api/[controller]/medicineControl")]
        public async Task<IActionResult> medicineControl(int userId)
        {
            try
            {
                var status = false;
                var medicineControl = new getMedicineControlRequest();


                DateTime now = DateTime.Now;
                TimeSpan timeOnly = now.TimeOfDay;
                var medicineList = await _medicinesService.MedicineControl(userId);

                foreach (var moon in medicineList.Select(s => new { name = s.Name, time = s.MoonTime }))
                {

                    if (moon.time == timeOnly.ToString(@"hh\:mm"))
                    {

                        medicineControl.name = moon.name;
                        medicineControl.status = true;

                        return Ok(new ResponseModel { message = "Success", data = medicineControl });
                    }
                }
                foreach (var afternoon in medicineList.Select(s => new { name = s.Name, time = s.AfternoonTime }))
                {

                    if (afternoon.time == timeOnly.ToString(@"hh\:mm"))
                    {

                        medicineControl.name = afternoon.name;
                        medicineControl.status = true;
                        return Ok(new ResponseModel { message = "Success", data = medicineControl });
                    }
                }
                foreach (var evening in medicineList.Select(s => new { name = s.Name, time = s.EveningTime }))
                {

                    if (evening.time == timeOnly.ToString(@"hh\:mm"))
                    {

                        medicineControl.name = evening.name;
                        medicineControl.status = true;
                        return Ok(new ResponseModel { message = "Success", data = medicineControl });
                    }
                }
                foreach (var night in medicineList.Select(s => new { name = s.Name, time = s.NightTime }))
                {

                    if (night.time == timeOnly.ToString(@"hh\:mm"))
                    {

                        medicineControl.name = night.name;
                        medicineControl.status = true;
                        return Ok(new ResponseModel { message = "Success", data = medicineControl });
                    }
                }

                medicineControl.name = "-";
                medicineControl.status = false;

                return Ok(new ResponseModel { message = "Success", data = medicineControl });

            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = false });
            }
        }
    }
}
