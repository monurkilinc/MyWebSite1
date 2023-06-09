using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Blog
{

	public class WriterLastBlog:ViewComponent
	{
		BlogManager bm=new BlogManager(new EFBlogRepository());


		//No:79 Üstte bm nesnesi üretildi ve Invoke metoduyla values return edildi
		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListByWriter(1);
			return View(values);
		}

	}
}
