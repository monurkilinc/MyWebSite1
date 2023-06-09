
//No:54 @item.Category.CategoryName ifadesini kullanabilmek için BlogRepositoryye ihitacımız kalmadı
//Sebebi Generic yapı kullandığımızdan dolayı.Bu yüzden sildik




//using DataAccessLayer.Abstract;
//using DataAccessLayer.Concrete;
//using EntityLayer.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.Repositories
//{
//    public class BlogRepository : IBlogDAL
//    {
//        public void AddBlog(Blog blog)
//        {
//            //No:21 Ekleme ve kaydetme işlemleri
//            using var c = new Context();
//            c.Add(blog);
//            c.SaveChanges();
//        }

//        public void Delete(Blog t)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeleteBlog(Blog blog)
//        {
//            //No:21 Silme ve kaydetme işlemleri
//            using var c = new Context();
//            c.Remove(blog);
//            c.SaveChanges();
//        }

//        public List<Blog>? GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public Blog GetById(int id)
//        {
//            //No:21 ID yi bulma ve return işlemleri
//            using var c = new Context();
//            return c.Blogs.Find(id);
//        }

//        public Blog GetByID(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Insert(Blog t)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Blog> ListAllBlog()
//        {
//            //No:21 Listeleme ve return işlemleri
//            using var c = new Context();
//            return c.Blogs.ToList();
//        }

//        public void Update(Blog t)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateBlog(Blog blog)
//        {
//            //No:21 Güncelleme ve kaydetme işlemleri
//            using var c = new Context();
//            c.Update(blog);
//            c.SaveChanges();
//        }
//    }
//}
