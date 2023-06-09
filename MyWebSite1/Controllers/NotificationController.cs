using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
    public class NotificationController : Controller
    {
        //No:104 GetList metodu için nm nesnesi türetildi
        NotificationManager nm=new NotificationManager(new EFNotificaitonRepository());
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        //No:104 Bildirimlerin listelenmesi için eklendi
        public IActionResult AllNotification()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
