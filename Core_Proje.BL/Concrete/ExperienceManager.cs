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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public List<Experience> GetbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
