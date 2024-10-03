using Core_Proje.BL.Concrete;
using Core_Proje.DAL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            // Giriş yapan kullanıcının kimliğini al
            var userId = User.Identity.Name; // veya User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Giriş yapan kullanıcının bilgilerini al
            var user = context.Users.FirstOrDefault(u => u.UserName == userId);
            ViewBag.userImage = user?.ImageUrl; // Kullanıcının ImageUrl'sini al ve ViewBag'e ata

            var values = portfolioManager.TGetList(); // Portföy verilerini al
            return View(values);
        }
    }
}
