using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace MyWebSite1.Controllers
{
	public class RegisterController : Controller
	{
		//No:77 Ekleme işlemi yapılırken HttpGet ve HttpPost attributelerinin tanımlandığı metotların isimleri aynı olmak zorundadır

		//No:77 Eğer HttpGet ve HttpPost attributeleri kullanılmazsa sayfa yuklenir yuklenmez direk post işlemi gerçekleşir, 
		//veri tabanına hemen kaydeder ve NULL değer kaydeder!!!


		WriterManager wm=new WriterManager(new EFWriteRepository());



		//No:77 Sayfa yüklenince çalışır
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		//No:77 Kayıt ol butonuna basınca çalışır.
		//No:77 Bir parametre alması gerekir
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv = new WriterValidator();
			//No:78 FluentValidation.Results ile kullan;
			ValidationResult results=wv.Validate(p);

			//No:78 Fluent Validation kullanımı
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme Test";
				wm.TAdd(p);


				return RedirectToAction("Index", "Blog");
			}
			else
			{
				//No:78 SONUCLAR Hata verirse ilgi kısıma ait hataları ekrana yazdırmak için bu kısmı kullandık
				foreach(var item in results.Errors)
				{

					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();

			//No:77 Register kısmında almadığımız WriterStatus ve WriterAbout kısmını burada aldık.Hata vermemesı için
			//No:77 Writer sınıfından p parametresi belirleyip aşağıda WriterAdd ile p parametresini aldık ve Kullanıcı kayıt
			//olduktan sonra Index/Blog sayfasına geri dönmesi sağlandı

			//Controller tarafından gönderdik!!!

			//No:78 Fluent Validation için yukarıda kullandık!!!


			//p.WriterStatus = true;
			//p.WriterAbout = "Deneme Test";
			//wm.WriterAdd(p);


			//return RedirectToAction("Index","Blog");
		}
	}
}
