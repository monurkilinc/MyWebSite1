 using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{

    //No:30 IGenericDAL<Blog> ifadesi eklenerek Category ve Blog interfacelerinin içindeki 
    //  Add,Delete,Update,GetById,ListAll gibi metotları tekrar kullanmak yerine IGenericDAL.cs duzenleyecegiz
    
    public interface IBlogDAL:IGenericDAL<Blog>
    {
        //NO:29 EntityFrameWork Repository tanımlamak için silindi

        //No:18 Interface tanımlanması için eklenmesi gereken değişkenler
        //List<Blog> ListAllBlog();
        //void AddBlog(Blog blog);
        //void DeleteBlog(Blog blog);
        //void UpdateBlog(Blog blog);
        //Blog GetById(int id);

        //No:54 @item.Category.CategoryName ifadesini kullanabilmek için ekledik
        List<Blog> GetListWithCategory();

        //No:95 Bloglardan Kategori adının listelenmesi için tanımladık
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}
