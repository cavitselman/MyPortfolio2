using Core_Proje.BL.Abstract;
using Core_Proje.DAL.Abstract;
using Core_Proje.EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.BL.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public List<Portfolio> GetbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
    }
}
