using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	//No:32 : GenericRepository<About>, IAboutDAL ifadesi eklendi
	public class EFBlogRepository : GenericRepository<Blog>, IBlogDAL
	{
		public List<Blog> GetListWithCategory()
		{
			//No:54 @item.Category.CategoryName ifadesini kullanabilmek için ekledik

			using (var c = new Context())
			{ 
				return c.Blogs.Include(x => x.Category).ToList();
			}
		}
        
        //No:95 Bloglardan Kategori adının listelenmesi için tanımladık
        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
            }
        }
    }
}
