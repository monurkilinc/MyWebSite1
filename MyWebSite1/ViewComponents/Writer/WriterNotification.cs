using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {


        //No:92 Invoke ViewComponentinin eklenmesi

        //No:103 NotificationList.cs teki metotlar buraya yapıştırıldıç Notification için eklendi.
        NotificationManager nm = new NotificationManager(new EFNotificaitonRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.GetList();
            return View(values);
        }


    }
}