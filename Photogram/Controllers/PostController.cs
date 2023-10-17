using Microsoft.AspNetCore.Mvc;

namespace Photogram.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
