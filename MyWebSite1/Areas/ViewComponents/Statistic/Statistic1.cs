using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace MyWebSite1.Areas.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    { 
        BlogManager bm=new BlogManager(new EFBlogRepository());
        Context c=new Context();
        //No:119 Invoke metodu eklendi
        public IViewComponentResult Invoke()
        {
            
            //No:119 Toplam Blog sayısını İstatistic sayfasında göstermek için eklendi
            ViewBag.v1 = bm.GetList().Count();
            //No:119 Toplam mesaj sayısını İstatistic sayfasında göstermek için eklendi
            ViewBag.V2=c.Contacts.Count();
            //No:119 Toplam yorum sayısını İstatistic sayfasında göstermek için eklendi
            ViewBag.v3=c.Comments.Count();


            //No:121 API Üzerinden Hava Durumu Bilgisi çekme için eklendi
            string api = "f7d57566dab687119f489e8d4b1822e3";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Istanbul&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("min").Value;
            ViewBag.v6 = document.Descendants("temperature").ElementAt(0).Attribute("max").Value;
            return View();
        }
        
    }
}
