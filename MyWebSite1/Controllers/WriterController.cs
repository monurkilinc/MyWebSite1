using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite1.Models;

namespace MyWebSite1.Controllers
{

	

	//no:86 Controller seviyesinde Authorize işlemiyle WriterControllerdaki tüm işlemlere sınırlama getirdik

	//No:87 Program.cs de Authorize işlemi yaptık ondan gerek kalmadı
	//[Authorize]
	public class WriterController : Controller
	{

		
		WriterManager wm=new WriterManager(new EFWriteRepository());


		//No:86 Authorize ekledik
		//[Authorize]

		//No:88 LOGIN İŞLEMİ İÇİN SİLİNDİ
		//[AllowAnonymous]
		[Authorize]
		public IActionResult Index()
		{
			//No:110 Login işlemiden sonra bize kullanıcıya ait mail adresini getirmek içi yazıldı
			var usermail = User.Identity.Name;
			ViewBag.v=usermail;
			Context c = new Context();
			var writerName=c.Writers.Where(x=>x.WriterMail==usermail).Select(y=>y.WriterName).FirstOrDefault();
			ViewBag.v2=writerName;
			var writerabout=c.Writers.Where(x=>x.WriterMail==usermail).Select(y=>y.WriterAbout).FirstOrDefault();
            ViewBag.v3 = writerabout;
            return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
		
		public IActionResult WriterMail()
		{
			return View();
		}
		//No:90 Yazar Paneli Teması için eklenen action
		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();

		}
        //No:91 WriterNavbarPartial ekledik ve Add View/Partial,layout ile WriterNavbarPartial.cshtml partialı türettik
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}
        //No:91 WriterFooterPartial ekledik ve Add View/Partial,layout ile WriterFooterPartial.cshtml partialı türettik

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}

		//No:101 Yazar profil bilgilerini getirmek için türetikdi
	
		[HttpGet]
		public IActionResult WriterEditProfile()
		{
			//No:111 WriterEditProfile kısmında yazarın ID sine göre bilgilerinin gelmesi için WriterAboutOnDashboarddaki metotlar burada kullanıldı
			Context c= new Context();
            var usermail = User.Identity?.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.TGetById(writerID);
            return View(values);
		}

        //No:101 Yazar Bilgilerini güncellemek için yazılan Validasyon Kuralları

        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
			WriterValidator wl= new WriterValidator();
			ValidationResult results = wl.Validate(p);

			if (results.IsValid)
			{
				wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }
			else
			{
				foreach(var item in results .Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

            return View();
        }

		//No:102 Profil fotoğraflarını dosyadan yüklemek için eklendi

		[AllowAnonymous]
		[HttpGet]
		public IActionResult WriterAdd()
		{
			return View();
		}

        [AllowAnonymous]
        [HttpPost]

		//No:102 Writer sınıfı yerine AddProfileImage sınıfı yazıldı
        public IActionResult WriterAdd(AddProfileImage p)
        {
			//No:102 Resim ekleme için izlenmesi gereken yol yazıldı.ÇOK ÖNEMLİ MUTLAKA DİKKATLE BAK!!!
			Writer w = new Writer();
			if(p.WriterImage!= null)
			{
				var extension = Path.GetExtension(p.WriterImage.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", newimagename);
				var stream = new FileStream(location,FileMode.Create);
				p.WriterImage.CopyTo(stream);
				w.WriterImage = newimagename;
			}
			w.WriterMail=p.WriterMail;
			w.WriterName=p.WriterName;
			w.WriterPassword=p.WriterPassword;
			w.WriterStatus = true;
			w.WriterAbout = p.WriterAbout;
			wm.TAdd(w); 

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
