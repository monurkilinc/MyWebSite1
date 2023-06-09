using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Category
{
	//No:76 CategoryList classı oluşturuldu,ViewComponentten miras aldı ve values return edildi

	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EFCategoryRepository());
		
		//No:76 
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList();
			return View(values);	
		}

	}
}
