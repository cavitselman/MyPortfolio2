using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
