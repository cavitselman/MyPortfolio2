using Core_Proje.BL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Core_Proje.EL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values=announcementManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement= announcementManager.TGetByID(id);
            return View(announcement);
        }
    }
}
