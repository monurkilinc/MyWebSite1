
//No:54 @item.Category.CategoryName ifadesini kullanabilmek için CategoryRepository ye ihitacımız kalmadı
//Sebebi Generic yapı kullandığımızdan dolayı.Bu yüzden sildik



//using DataAccessLayer.Abstract;
//using DataAccessLayer.Concrete;
//using EntityLayer.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.Repositories
//{
//    //No:19 CategoryRepository içinde ICategoryDAL sınıfını miras olarak alabilmek için; 
//    //AddCategory,DeleteCategory,GetById,ListAllCategory,UpdateCategory implement etmek gerekir!!!
//    public class CategoryRepository : ICategoryDAL
//    {
//        Context c=new Context();


//        public void AddCategory(Category category)
//        {
//            //No:20 Ekleme ve kaydetme işlemleri
//            c.Add(category);
//            c.SaveChanges();

//        }

//        public void Delete(Category t)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeleteCategory(Category category)
//        {
//            //No:20 Silme ve değişiklikleri kaydetme işlemleri
//            c.Remove(category);
//            c.SaveChanges();
//        }

//        public List<Category> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        //void türünde olmayan değiskenlerin altındaki değerleri sildiğimizde hata verir
//        public Category GetById(int id)
//        {
//            //No:20 ID Bulma ve Return işlemleri
//            return c.Categories.Find(id);
//        }

//        public Category GetByID(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Insert(Category t)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Category> ListAllCategory()
//        {
//            //No:20 Listeleme işlemi
//            return c.Categories.ToList();
//        }

//        public void Update(Category t)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateCategory(Category category)
//        {
//            //No:20 Güncelleme ve değişiklikleri kaydetme işlemi
//            c.Update(category);
//            c.SaveChanges();
//        }
//    }
//}
