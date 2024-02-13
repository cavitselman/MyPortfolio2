using DenemeCore.DAL.Concrete;
using DenemeCore.EL.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace DenemeCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            //Weather APİ
            string api = "705c752b762674f6e626582ef40282a4";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=alasehir&mode=xml&lang=tr&units=metric&appid=705c752b762674f6e626582ef40282a4";
            XDocument document=XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            //statistics
            Context c = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();
            return View();
        }
    }
}
/* https://api.openweathermap.org/data/2.5/weather?q=alasehir&mode=xml&lang=tr&units=metric&appid=705c752b762674f6e626582ef40282a4 */