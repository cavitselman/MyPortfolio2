using DenemeCore.DAL.Abstract;
using DenemeCore.EL.Concrete;
using DenemeCore.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DenemeCore.DAL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DenemeCore.DAL.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        public List<UserMessage> GetUserMessagesWithUser()
        {
            using (var c = new Context())
            {
                return c.UserMessages.Include(x=>x.User).ToList();
            }
        }
    }
}
