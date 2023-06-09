using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
	public class NewsLetterController : Controller
	{
		//No.80 nm adında nesne türetildi 
		NewsLetterManager nm=new NewsLetterManager(new EFNewsLetterRepository());

		//No:80 PartialView olarak değiştirdik
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter p)
		{
			p.MailStatus = true;
			nm.AddNewsLetter(p);

			//No:80 Mail girişinden sonra Blog sayfasına geri dönmesi için böyle yazıldı
			Response.Redirect("/Blog/BlogReadAll/" + 1);
			return PartialView();
		}

	}
}
