using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    //No:24 GenericRepository IGenericDAL dan miras alarak Generic hale getirildi
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        //No:25 Generic Repository içinde implement edilen metotların düzenlenmesi
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
        //No:25 Generic Repository içinde implement edilen metotların düzenlenmesi
        public List<T>? GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }
        //No:25 Generic Repository içinde implement edilen metotların düzenlenmesi
        public T GetByID(int id)
        {

            using var c = new Context();
            return c.Set<T>().Find(id);
        }
        //No:25 Generic Repository içinde implement edilen metotların düzenlenmesi
        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();

        }

        //No:61 BlogDetails ta blog göre listeleme yapmak için ekledik ve return ettik.
		public List<T>? GetListAll(Expression<Func<T, bool>> filter)
		{
			using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
		}

		//No:25 Generic Repository içinde implement edilen metotların düzenlenmesi
		public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
