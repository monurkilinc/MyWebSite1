using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyWebSite1.Controllers
{
    public class MessageController : Controller
    {
        //No:109 Dashboard Mesaj sekmesi ve mesaj detayları için eklendi
        Message2Manager mm=new Message2Manager(new EFMessage2Repository());
        [AllowAnonymous]
        public IActionResult SendBox()
        {
            int id = 2;
            var values=mm.GetInboxListByWriter(id);
            return View(values);
        }


        //No:109 Dashboard Mesaj Details için eklendi
        [AllowAnonymous]
        public IActionResult MessageDetails(int id)
        {

            var value = mm.TGetById(id);

            return View(value);
        }
    }
}
