using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.Controllers
{
	public class CommentController : Controller
	{
		//NO:71 Aşğıda cm adlı nesne türetildi
		CommentManager cm = new CommentManager(new EFCommentRepository());

		public IActionResult Index()
		{
			return View();
		}
		//No:66 CommentController eklenmesi ve PartialAddComment metodunun yazılması
		//No:81 Bloglara yorum ekleme için [HttpGet] attribute kullandık
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		//No:81 Bloglara yorum ekleme için [HttpPost] attribute kullandık,
		//Comment p parametresi aldık(HttpPost parametresiz kullanılamaz
		

		[HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
		{
			//No:81 Bloglara yorum için aşağıdaki metotları ekledik
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 2;
			cm.CommentAdd(p);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			//No:71 int id tanımlandı ve values değeri return edildi
			var values=cm.GetList(id);
			return PartialView(values);
		}
	}
}
