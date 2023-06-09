using Microsoft.AspNetCore.Mvc;
using MyWebSite1.Models;

namespace MyWebSite1.ViewComponents
{
	public class CommentList : ViewComponent
	{
		//No:73 ViewComponent eklenmesi ve blog yorum sayfası için kullanıcı ID ve UserNamelerin alınması
		public IViewComponentResult Invoke()
		{
            //No:74 Kullanıcı yorumları için ID ve UserName parametrelerinin girişlerinin yapılması

            var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					UserName="Onur"
				},
				new UserComment
				{
					ID = 2,
					UserName="Emre"
				},
				new UserComment
				{
					ID = 3,
					UserName="Murat"
				}
			};
			return View(commentvalues);
		}

	}
}
