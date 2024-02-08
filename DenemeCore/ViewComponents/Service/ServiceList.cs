using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }

}
