using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    //No:32 :GenericRepository<Category>,ICategoryDAL ifadeleri eklenerek iki bölümdeki ifadelere erişim sağlandı
    public class EFCategoryRepository:GenericRepository<Category>,ICategoryDAL
    {
    }
}
