using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //No:93 Generic Service yapıları için : IGenericService<Category> ifadesi eklendi

    public interface ICategoryService:IGenericService<Category>
    {
        //No:93 Generic Service yapıları için yorum satırı haline getirdik


        //No:26 Add,Delete,Update,GetList ve GetById metotlarının eklenmesi
        //void CategoryAdd(Category category);
        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);

        //List<Category> GetList();
        //Category GetById(int id);
    }
}
