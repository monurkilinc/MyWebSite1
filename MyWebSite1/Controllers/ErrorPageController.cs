using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error1(int code)
		{

			return View();
		}
	}
}
