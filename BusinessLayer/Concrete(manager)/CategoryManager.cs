using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //NO:36 CategoryManager uzerinde CTRL+. Generate Constructor yaptık
    //No:93 ICategoryService Generic hale getirmek için implement ettik
    public class CategoryManager: ICategoryService
    {

        //No:33 Artık ihtiyacımız kalmadı
        //No:28 GenericRepository deki Category degerlerine ulaşabilmek için eklendi
        //GenericRepository<Category> repo=new GenericRepository<Category>();


        //No:27 CategoryManager : ICategoryService den miras aldı  
        //Add,Delete,Update,GetById,GetList metotlarını implement ettik.


        //NO:34 EFCategoryRepository oluşturuldu ve Constructer Metot oluşturuldu
        //No:36 _categoryDAL field ı ile artık efCategoryRepository ye gerek kalmadı
        //EFCategoryRepository efCategoryRepository;

        

        //No:36 _categoryDAL ile bu metoda gerek kalmadıgı için silindi

        //public CategoryManager()
        //{

        //    //efCategoryRepository = new EFCategoryRepository();
           
        //}

//public void CategoryAdd(Category category)
        //{
        //    //No:35 Metotların düzenlenmesi
        //    //efCategoryRepository.Insert(category);

        //    //no:36 _categoryDAL seklinde düzenlenme
        //    _categoryDAL.Insert(category);
        //}

        //public void CategoryDelete(Category category)
        //{
        //    //No:33 Düzenleme için silindi 
        //    //No:28 Silme işleminin bir şarta bağlanması
        //    //if (category.CategoryID != 0)
        //    //{
        //    //    repo.Delete(category);
        //    //}


        //    //No:35 Metotların düzenlenmesi
        //    //efCategoryRepository.Delete(category);

        //    //no:36 _categoryDAL seklinde düzenlenme

        //    _categoryDAL.Delete(category);
        //}

        //public void CategoryUpdate(Category category)
        //{

        //    //No:35 Metotların düzenlenmesi
        //    //efCategoryRepository.Update(category);

        //    //no:36 _categoryDAL seklinde düzenlenme
        //    _categoryDAL.Update(category);
        //}

        //No:93 IGenericService implement edildi ve aşağıdaki metotlar eklendi(Generic hale getirmek için)
        //public List<Category> GetListAll()
        //{
        //    return _categoryDAL.GetListAll();
        //}
        
        
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            //No:36 _categoryDAL olarak düzenlenmesi
            _categoryDAL = categoryDAL;
        }



        //No:93 Generic için bu metotlar yeterli
        public Category TGetById(int id)
        {

            //No:35 Metotların düzenlenmesi
            //return efCategoryRepository.GetByID(id);

            //no:36 _categoryDAL seklinde düzenlenme
            return _categoryDAL.GetByID(id);
        }


        public List<Category> GetList()
        {

            //No:35 Metotların düzenlenmesi
            //return efCategoryRepository.GetAll();

            //no:36 _categoryDAL seklinde düzenlenme
            return _categoryDAL.GetListAll();
        }

        //No:93 IGenericService implement edildi ve aşağıdaki metotlar eklendi(Generic hale getirmek için)

        public void TAdd(Category t)
        {
            _categoryDAL.Insert(t);

        }

        public void TDelete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
