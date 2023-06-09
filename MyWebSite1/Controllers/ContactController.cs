using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
	public class ContactController : Controller
	{

		//No:84 cm nesnesi türetildi
		ContactManager cm = new ContactManager(new EFContactRepository());


		//No:84 HttpGet ve HttpPost tanımladık
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		//No:84 HttpPost olmasından dolayı cm nesnesini parametre olarak girdik
		[HttpPost]
		public IActionResult Index(Contact p)
		{
			//No:84 Elle girilmesi gereken parametrelere değer atandı ve ContactAdd eklendi

			p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContactStatus = true;
			cm.ContactAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
