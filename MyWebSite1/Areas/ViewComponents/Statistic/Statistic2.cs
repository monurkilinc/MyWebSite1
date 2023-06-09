using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Areas.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        Context c=new Context();
        //No:119 İstatistik 2 için eklenen metot.
        public IViewComponentResult Invoke()
        {
            //No:119 En son bloğu İstatistic sayfasında göstermek için eklendi
            ViewBag.v1 = c.Blogs.OrderByDescending(x=>x.BlogID).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();

            return View();
        }

    }
}
