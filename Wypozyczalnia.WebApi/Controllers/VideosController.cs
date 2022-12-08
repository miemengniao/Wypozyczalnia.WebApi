using Microsoft.AspNetCore.Mvc;
using Wypozyczalnia.Core;

namespace Wypozyczalnia.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideosController : ControllerBase
    {

        private readonly IVideoServices _videoServices;
        public VideosController(IVideoServices videoServices)
        {
            _videoServices = videoServices;
        }

        [HttpGet]
        public IActionResult GetVideos()
        {
            return Ok(_videoServices.GetVideos());
        }
    }
}