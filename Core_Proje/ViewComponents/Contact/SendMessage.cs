using Core_Proje.BL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Core_Proje.EL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage : ViewComponent

    {
        public IViewComponentResult Invoke()

        {
            return View();
        }
    }
}
