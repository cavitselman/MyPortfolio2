using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {            
        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values= portfolioManager.TGetList().OrderByDescending(x=>x.PortfolioID).Take(5).ToList();
            return View(values);
        }
    }
}