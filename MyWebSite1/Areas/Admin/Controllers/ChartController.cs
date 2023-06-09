using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite1.Areas.Admin.Models;

namespace MyWebSite1.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }
        //No:122 CategoryChart action ı eklendik
        
        public IActionResult CategoryChart() 
        { 
            List<CategoryClass> list= new List<CategoryClass>();
            list.Add(new CategoryClass 
            {
                categoryname = "Teknoloji",
                categorycount = 10
            
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14

            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5

            });
            list.Add(new CategoryClass
            {
                categoryname = "Sinema",
                categorycount = 2

            });
            //No:122 Chartları Json formatında scriptle kullanıcaz.
            return Json(new {jsonlist=list });
        }
    }
}
