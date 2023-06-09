using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
    public class Category : Controller
    {
        //No:37 cm nesnesiyle bütün metotlara erişim sağlanabilir
        CategoryManager cm=new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            //No:37
            var values = cm.GetList();
            return View(values);
        }
    }
}
