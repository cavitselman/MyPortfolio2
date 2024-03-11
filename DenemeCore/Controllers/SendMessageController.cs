using DenemeCore.BL.Concrete;
using DenemeCore.DAL.EntityFramework;
using DenemeCore.EL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DenemeCore.Controllers
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
