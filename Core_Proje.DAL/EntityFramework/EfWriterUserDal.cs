using Core_Proje.DAL.Abstract;
using Core_Proje.DAL.Repository;
using Core_Proje.EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.DAL.EntityFramework
{
    public class EfWriterUserDal : GenericRepository<WriterUser>, IWriterUserDal
    {
    }
}
