using Core_Proje.BL.Concrete;
using Core_Proje.DAL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Core_Proje.EL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.TGetByID(id);
            if (values.Receiver== p)
            {
                writerMessageManager.TDelete(values);
                return RedirectToAction("ReceiverMessageList");
            }
            else
            {
                writerMessageManager.TDelete(values);
                return RedirectToAction("SenderMessageList");
            }
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
