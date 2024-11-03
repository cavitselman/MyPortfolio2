using Core_Proje.BL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values = portfolioManager.TGetList().OrderByDescending(x => x.PortfolioID).Take(5).ToList();
            return View(values);
        }
    }
}