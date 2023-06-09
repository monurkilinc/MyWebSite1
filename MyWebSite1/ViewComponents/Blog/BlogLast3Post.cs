using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Blog
{

	public class BlogLast3Post : ViewComponent
	{
		//No:89 Son Postlar kısmı için eklenen parametreler

		BlogManager bm = new BlogManager(new EFBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetLast3Blog();
			return View(values);
		}
	}
}
