using DenemeCore.DAL.Abstract;
using DenemeCore.EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeCore.DAL.Abstract
{
    public interface IUserMessageDal : IGenericDal<UserMessage>
    {
        public List<UserMessage> GetUserMessagesWithUser();
    }
}
