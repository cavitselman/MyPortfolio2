using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using DenemeCore.EL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Contact
{
    public class SendMessage : ViewComponent

    {
        public IViewComponentResult Invoke()

        {
            return View();
        }
    }
}
