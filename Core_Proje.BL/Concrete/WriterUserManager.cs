using Core_Proje.BL.Abstract;
using Core_Proje.DAL.Abstract;
using Core_Proje.EL.Concrete;

namespace Core_Proje.BL.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public List<WriterUser> GetbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(WriterUser t)
        {
            _writerUserDal.Insert(t);
        }

        public void TDelete(WriterUser t)
        {
            _writerUserDal.Delete(t);
        }

        public WriterUser TGetByID(int id)
        {
            return _writerUserDal.GetByID(id);
        }

        public List<WriterUser> TGetList()
        {
            return _writerUserDal.GetList();
        }

        public void TUpdate(WriterUser t)
        {
            _writerUserDal.Update(t);
        }
    }
}
