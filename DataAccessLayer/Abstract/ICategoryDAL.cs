using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //No:30 ":IGenericDAL<Category>" ifadesi eklenerek Category ve Blog interfacelerinin içindeki 
    //  Add,Delete,Update,GetById,ListAll gibi metotları tekrar kullanmak yerine IGenericDAL.csde
    //  tek bir sefer kullanacagız

    public interface ICategoryDAL : IGenericDAL<Category>
    {
        //NO:29 EntityFrameWork Repository tanımlamak için silindi

        //No:17 Interface tanımlanması için eklenmesi gereken değişkenler
        //List<Category> ListAllCategory();
        //void AddCategory(Category category);
        //void DeleteCategory(Category category);
        //void UpdateCategory(Category category);
        //Category GetById(int id);
    }
}
