using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
	public class AboutController : Controller
	{
        //No:83 abm türetildi
        AboutManager abm = new AboutManager(new EFAboutRepository());

		public IActionResult Index()
		{
			//No:83 values return edildi ve GetList 
			var values = abm.GetList();
			return View(values);
		}


		//No:83 SocialMediaAbout metodu ekledik ve Partial View seklinde Views/About/SocialMediaAbout.cshtml ekledik
		public PartialViewResult SocialMediaAbout()
		{
			
			return PartialView();
		}
	}
}
