using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
