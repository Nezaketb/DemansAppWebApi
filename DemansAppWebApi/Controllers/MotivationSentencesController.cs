using DemansAppWebApi.Entities;
using DemansAppWebApi.Services;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class MotivationSentencesController : Controller
    {
        private readonly IMotivationSentencesService _sentenceService;

        public MotivationSentencesController(IMotivationSentencesService sentenceService)
        {
            _sentenceService = sentenceService;
        }


        [HttpGet("~/api/[controller]")]
        public async Task<ActionResult<IEnumerable<MotivationSentences>>> GetAllSentencesAsync()
        {
            try
            {
                var sentences = await _sentenceService.GetAllSentencesAsync();
                return Ok(new ResponseModel { message = "Success", data = sentences });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpPost("~/api/[controller]")]
        public async Task<IActionResult> AddUser([FromBody] MotivationSentences sentence)
        {
            try
            {
                await _sentenceService.AddSentenceAsync(sentence);
                return Ok(new ResponseModel { message = "Success", data = sentence });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}
