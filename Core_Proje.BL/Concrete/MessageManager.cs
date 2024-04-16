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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
