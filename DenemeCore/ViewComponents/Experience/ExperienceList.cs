using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
    }
}
