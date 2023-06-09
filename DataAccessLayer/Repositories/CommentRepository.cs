
//No:54 @item.Category.CategoryName ifadesini kullanabilmek için CommentRepository ye ihitacımız kalmadı
//Sebebi Generic yapı kullandığımızdan dolayı.Bu yüzden sildik.

//using DataAccessLayer.Abstract;
//using EntityLayer.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.Repositories
//{
//    //No:23 CommentRepository eklendi Generic hale getirildi ve implement edildi
//    public class CommentRepository : IGenericDAL<Comment>
//    {
//        public void Delete(Comment t)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Comment> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public Comment GetByID(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Insert(Comment t)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Comment t)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
