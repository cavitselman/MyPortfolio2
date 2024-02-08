using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}
