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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
