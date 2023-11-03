using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N58Home.Api.Services;

namespace N58Home.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebRootController : ControllerBase
    {
        private readonly WebBroker _webBroker;

        public WebRootController(WebBroker webBroker)
        {
            _webBroker = webBroker;
        }

        [HttpGet("directory")]
        public async ValueTask<IActionResult> GetDirectories() =>
            Ok(await _webBroker.GetDirectories());

        [HttpGet("files")]
        public async ValueTask<IActionResult> GetFiles() =>
            Ok(await _webBroker.GetFiles());
    }
}