using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeCore.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
