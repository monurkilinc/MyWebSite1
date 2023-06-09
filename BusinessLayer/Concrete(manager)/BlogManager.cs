using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    //No:55 IBlogService i implement interface ettik
    //No:93 IBlogService implement edildi ve TAdd,TDelete... metotları eklendi
    public class BlogManager : IBlogService
	{	
		//NO:48 Blogmanager Generate constructor yapıldı ve _blogDAL metodu ile düzenlendi
		IBlogDAL _blogDAL;

		public BlogManager(IBlogDAL blogDAL)
		{
			_blogDAL = blogDAL;
		}
		

		public List<Blog> GetBlogListWithCategory()
		{
			//No:55 Aşağıdaki ifade return edildi
			return _blogDAL.GetListWithCategory();
		}
        //No:96 Blog Silme işlemi için
        //No:96 GetById =>TGetByID olarak düzenlendi
        //public Blog GetById(int id)

        public Blog TGetById(int id)
		{
			return _blogDAL.GetByID(id);
		}
        

        //No:61 BlogDetails ta blog göre listeleme yapmak için ekledik ve return ettik.

        public List <Blog> GetBlogByID(int id) 
		{
			return _blogDAL.GetListAll(x => x.BlogID == id);
		
		}
		public List<Blog> GetList()
		{
			return _blogDAL.GetListAll();

		}

		//NO:89 Son Postlar kısmı için eklendi
		public List<Blog> GetLast3Blog()
		{
			return _blogDAL.GetListAll().Take(3).ToList();
		}


        //nO:95 Bloglardan Kategori adının listelenmesi için tanımladık

        public List<Blog> GetListWithCategoryByWriterBM(int id)
		{
            return _blogDAL.GetListWithCategoryByWriter(id);
        }



		//No:79 Yazarın diğer yazıları bölümü için implement edildi
		public List<Blog> GetBlogListByWriter(int id)
		{
			//No:79 WriterID ile dısarıdan gönderilen id değerlerini return ettik
			return _blogDAL.GetListAll(x => x.WriterID == id);
		}



        //No:93 IBlogService implement edildi ve TAdd,TDelete... metotları eklendi
        public void TAdd(Blog t)
        {
            _blogDAL.Insert(t);
        }
		//No:96 Blog Silme işlemi için düzenledik
        public void TDelete(Blog t)
        {
            _blogDAL.Delete(t);
        }
		//No:97 Blog düzenleme için eklendi
        public void TUpdate(Blog t)
        {
            _blogDAL.Update(t);
		}


	}

}

//No:93 Generic yapınca ihtiyaç kalmadı
//public void BlogAdd(Blog blog)
//{
//	throw new NotImplementedException();
//}

//public void BlogDelete(Blog blog)
//{
//          throw new NotImplementedException();
//      }

//      public void BlogUpdate(Blog blog)
//{
//          throw new NotImplementedException();
//      }


