using Core_Proje.BL.Abstract;
using Core_Proje.DAL.Abstract;
using Core_Proje.EL.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.BL.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public List<Service> GetbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
