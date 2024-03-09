using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using DenemeCore.EL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditTestimonial(int id)
        {
            var values=testimonialManager.TGetByID(id);
            return View(values);
        }
        
        [HttpPost]
        public ActionResult EditTestimonial(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
