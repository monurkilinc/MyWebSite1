using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Blog
{
    //No:98 Blogları Dashboardda listelemek için aşağıdaki metot oluşturuldu

    public class BlogListDashboard:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
