using Core_Proje.BL.Concrete;
using Core_Proje.DAL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            Context c = new Context();
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            var img1 = c.WriterMessages.Where(x => x.Receiver == p).Select(z => z.Sender).FirstOrDefault();
            var img2 = c.Users.Where(x => x.Email == img1).Select(z => z.ImageUrl).FirstOrDefault();
            ViewBag.v1 = img2;
            return View(values);
        }
    }
}
