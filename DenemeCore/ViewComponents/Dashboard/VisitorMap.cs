using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
