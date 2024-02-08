using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using DenemeCore.BL.Concrete;

namespace DenemeCore.ViewComponents.Dashboard
{
    public class ProjectList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}
