using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
