using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetUserMessagesWithUserService().OrderByDescending(x=>x.Date).Take(4).ToList();
            return View(values);
        }
    }
}
