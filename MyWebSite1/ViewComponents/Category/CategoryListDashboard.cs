using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Category
{

    //No:98 Kategorileri Dashboardda listelemek için oluşturulan class
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());

        
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
