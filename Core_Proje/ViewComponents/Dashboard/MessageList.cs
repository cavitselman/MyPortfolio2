using Core_Proje.BL.Concrete;
using Core_Proje.DAL.Concrete;
using Core_Proje.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetList().Take(5).ToList();
            var imageUrls = new List<string>();

            foreach (var message in values)
            {
                // Mesajın atan kişisinin email'ini kontrol et
                var sender = context.Users.FirstOrDefault(x => x.Email == message.Mail);
                if (sender != null)
                {
                    imageUrls.Add(sender.ImageUrl); // Kullanıcının ImageUrl'sini listeye ekle
                }
                else
                {
                    imageUrls.Add(null); // Eğer kullanıcı bulunamazsa, null ekle
                }
            }

            ViewBag.ImageUrl = imageUrls; // Tüm ImageUrl'leri ViewBag'de sakla
            return View(values);
        }
    }
}
