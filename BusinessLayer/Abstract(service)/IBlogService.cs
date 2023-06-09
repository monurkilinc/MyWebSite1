using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{//No:93 :IGenericService<Blog> ifadesiyle Generic hale getirildi
    public interface IBlogService:IGenericService<Blog>
    {
        

		//No :55 EntityFRAMEWORK BlogRepository içerisinde metot tanımlandıktan sonra Business katmanının içinde çağırılması gerekir
		//Bu sebepten dolayı buraya asaşıdaki tanımı ekledik.
		List<Blog> GetBlogListWithCategory();

		//No:79 Yazarın diğer yazıları için oluşturduk
		List<Blog> GetBlogListByWriter(int id);
	}
}
        //No:93 :IGenericService<Blog> ifadesiyle asağıdaki metotlara ihtiyacımız kalmadı

        //NO:47 IBlogService interface eklenmesi ve metotların yazılması
        //void BlogAdd(Blog blog);
        //void BlogDelete(Blog blog);
        //void BlogUpdate(Blog blog);

        //List<Blog> GetList();
		//Blog GetById(int id);