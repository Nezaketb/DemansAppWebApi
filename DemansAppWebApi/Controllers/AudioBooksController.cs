using DemansAppWebApi.Entities;
using DemansAppWebApi.Services;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemansAppWebApi.Controllers
{
    public class AudioBooksController : Controller
    {
        private readonly IAudioBooksService _audioBooksService;

        public AudioBooksController(IAudioBooksService audioBooksService)
        {
            _audioBooksService = audioBooksService;
        }

        [HttpGet("~/api/[controller]/getAllBooks")]
        public async Task<ActionResult<IEnumerable<AudioBooks>>> GetAllBooksAsync()
        {
            try
            {
                var books = await _audioBooksService.GetAllBooksAsync();
                return Ok(new ResponseModel { message = "Success", data = books   });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }

        [HttpPost("~/api/[controller]/addBooks")]
        public async Task<IActionResult> AddCommand([FromBody] AudioBooks audioBook)
        {
            try
            {
                await _audioBooksService.AddBookAsync(audioBook);
                return Ok(new ResponseModel { message = "Success", data = audioBook });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseModel { message = "Error", data = ex.ToString() });
            }
        }
    }
}

