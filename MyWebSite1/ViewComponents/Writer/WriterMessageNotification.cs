using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Writer
{
    //No:92 WriterMessageNotification class eklenmesi ve ViewComponent
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager mm=new Message2Manager(new EFMessage2Repository());


       //No:104 Mesajlar için tanımladık
       //No:107 Yazara ait mesaj bildirimleri için düzenlendi
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
