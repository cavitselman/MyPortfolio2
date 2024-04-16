using Core_Proje.BL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Core_Proje.EL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SendMessageController : Controller
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());

        [HttpPost]
        public IActionResult Index(Message message)
        {
            message.Date = DateTime.Now.ToLocalTime();
            message.Status = true;
            _messageManager.TAdd(message);        
            return Redirect("/Default/Index#contact");
        }
    }
}
