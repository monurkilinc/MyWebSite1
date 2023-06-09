using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MyWebSite1.Controllers
{
	public class LoginController : Controller
	{
		//No:87 AllowAnonymous ifadesi yazılmasının sebebi Authorize işleminden dolayı sayfaya bi yerden erişebilmek.
		//
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		//No:88 LOGIN İŞLEMİ İÇİN AÇIKLAMA SATIRINA ÇEVRİLDİ
		//[HttpPost]
		//[AllowAnonymous]
		//No:87 Aşağıdaki işlemler Authorize işlemini Controller seviyesine taşımak için yapıldı

		//	//No:88 
		//public IActionResult Index(Writer p)
		//{

		//No:88 
		//	//Context c = new Context();
		//	//var datavalue=c.Writers.FirstOrDefault(x=>x.WriterMail==p.WriterMail && x.WriterPassword==p.WriterPassword);
		//	//if (datavalue!=null)
		//	//{
		//	//	HttpContext.Session.SetString("username",p.WriterMail);


		//	//	return RedirectToAction("Index", "Writer");

		//	//}
		//	//else
		//	//{
		//	//	return View();
		//	//}
		//}

		//No:88 LOGIN İŞLEMİ İÇİN CLAIMS KULLANIMI

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(Writer p)
		{
			Context c=new Context();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail== p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (datavalue!=null)
			{
				var claims=new List<Claim>
				{
					new Claim(ClaimTypes.Name, p.WriterMail)
				};

				var useridentity=new ClaimsIdentity(claims,"Login");
				ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index","Dashboard");
			}
			else { return View(); }
		}
	}
}
