using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Generic hale getirmek için IGenericDAL<T>where T : class ifadesini kullandık
    //No:22 Category ve Blog Abstractlarını Generic Repository haline çevirdik ve asagıdaki metotları ekledik
    public interface IGenericDAL<T>where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T>? GetListAll();

        T GetByID(int id);

        //No:61 BlogDetails ta bloga göre listeleme yapabilmek için ekledik
        List<T>? GetListAll(Expression <Func<T, bool>> filter);
    }
}
