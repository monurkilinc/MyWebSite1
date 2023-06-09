using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace MyWebSite1.Areas.ViewComponents.Statistic
{

    public class Statistic4:ViewComponent
    {
        //No:120 Admin paneli admin ekleme işlemi için oluşuturuldu
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Admins.Where(x => x.AdminID == 1).Select(x => x.Name).FirstOrDefault();
            ViewBag.v10 = c.Admins.Where(x => x.AdminID == 1).Select(x => x.Role).FirstOrDefault();
            ViewBag.v11=c.Admins.Where(x=>x.AdminID==1).Select(x=>x.ImageURL).FirstOrDefault();
            ViewBag.v2=c.Admins.Where(x=>x.AdminID==1).Select(x=>x.ShortDescription).FirstOrDefault();
            ViewBag.v3=c.Admins.Where(x=>x.AdminID==1).Select(x=>x.AdminEmail).FirstOrDefault();
            ViewBag.v4=c.Admins.Where(x=>x.AdminID==1).Select(x=>x.AdminAdress).FirstOrDefault();
            ViewBag.v5=c.Admins.Where(x=>x.AdminID==1).Select(x=>x.AdminContact).FirstOrDefault();
            return View();
        }


    }
}
