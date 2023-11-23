﻿using DemansAppWebApi.Entities;
using DemansAppWebApi.Services;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class CompanionsController : Controller
    {
        private readonly ICompanionsService _companionsService;
        public CompanionsController(ICompanionsService companionsService)
        {
            _companionsService = companionsService;
        }

        [HttpGet("~/api/[controller]")]
        public async Task<ActionResult<IEnumerable<Companions>>> GetAllCompanionsAsync()
        {
            try
            {
                var companions = await _companionsService.GetAllCompanionsAsync();
                return Ok(new ResponseModel { message = "Success", data = companions });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpGet("~/api/[controller]/{userId}")]
        public async Task<ActionResult<Companions>> GetCompanionsByUserId(int userId)
        {
            try
            {
                var companion = await _companionsService.GetCompanionsByUserIdAsync(userId);
                return Ok(new ResponseModel { message = "Success", data = companion });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}