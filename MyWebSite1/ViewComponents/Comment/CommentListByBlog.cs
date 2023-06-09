using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        //No:75 CommentListByBlog tanımlandı ViewComponent olarak düzenlendi EFCommentRepository de cm değeri oluşturuldu
        //values değeri return edildi
        CommentManager cm=new CommentManager(new EFCommentRepository());

        //No=75 ID degerine göre otomatik olarak yorum gelmesi için int id tanımlandı
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }


    }
}
