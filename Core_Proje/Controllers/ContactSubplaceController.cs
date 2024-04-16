using Core_Proje.BL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Core_Proje.EL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ContactSubplaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.TUpdate(contact);
            return Redirect("/Default/Index#contact");
        }
    }
}
