using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
