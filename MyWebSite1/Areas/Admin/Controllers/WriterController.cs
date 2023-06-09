using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite1.Areas.Admin.Models;
using Newtonsoft.Json;

namespace MyWebSite1.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            //No:123 JSON ile çalıştığımız için veriyi convert ettik
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters); 


        }
        //No:124 Dısarıdan gönderdiğimiz parametreye göre o parametredeki değeri getirmek için oluşturulan Action

        public IActionResult GetWriterById(int writerid)
        {
            //No:124 ID ye göre listeleme için eklendi
            var findWriter=writers.FirstOrDefault(x => x.Id == writerid);
            //No:124 convert işlemi
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);

        }
        //No:126 Ajax ile yazar ekleme için yazıldı
        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters=JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }
         //No:127 Ajax ile Yazar Silme için eklendi
        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);
        }
        //No:128 AJAX UPDATE İŞLEMİ İÇİN EKLENDİ
        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer=writers.FirstOrDefault(x=>x.Id == w.Id);
            writer.Name= w.Name;
            var jsonWriter=JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }


        //No:123 AJAX ILE VERILERIN CONSOLEDA LİSTELENMESİ İÇİN LİSTE EKLENDİ
        
        public static List<WriterClass> writers = new List<WriterClass>
        {

            new WriterClass
            {
                Id = 1,
                Name="Ayşe"
            },

            new WriterClass
            {
                Id = 2,
                Name="Ahmet"
            },
            new WriterClass
            {
                Id = 3,
                Name="Buse"
            },
        };
    }
}
