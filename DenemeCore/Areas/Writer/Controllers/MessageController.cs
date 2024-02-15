using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
