using DenemeCore.BL.Abstract;
using DenemeCore.EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeCore.BL.Abstract
{
    public interface IUserMessageService : IGenericService<UserMessage>
    {
        List<UserMessage> GetUserMessagesWithUserService();
    }
}
