using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        //No:93 Generic Service yapıları için ekledik
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);

        List<T> GetList();


        //No:96 Blog Silme işlemi için
        //No:96 GetById=>TGetById olarak düzenlendi
        //T GetById(int id);

        T TGetById(int id);

    }
}
