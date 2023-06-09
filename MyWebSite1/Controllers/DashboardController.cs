using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
    public class DashboardController : Controller
    {

        BlogManager bm=new BlogManager(new EFBlogRepository());
        
        //No:98 Dashboard Index sayfası türettik
        public IActionResult Index()
        {
            //No:100 Dashboardda Toplam Blog Sayısı,Sizin Blog Sayınız ve Toplam Kategori Sayısı için türetildi
            Context c = new Context();
            ViewBag.v1=c.Blogs.Count().ToString();
            ViewBag.v2=c.Blogs.Where(x=>x.WriterID==1).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
