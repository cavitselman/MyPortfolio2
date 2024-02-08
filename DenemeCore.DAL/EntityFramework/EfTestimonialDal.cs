using DenemeCore.DAL.Abstract;
using DenemeCore.DAL.Repository;
using DenemeCore.EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeCore.DAL.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
    }
}
