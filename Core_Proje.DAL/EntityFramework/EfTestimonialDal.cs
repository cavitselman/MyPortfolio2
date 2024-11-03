using Core_Proje.DAL.Abstract;
using Core_Proje.DAL.Repository;
using Core_Proje.EL.Concrete;

namespace Core_Proje.DAL.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
    }
}
