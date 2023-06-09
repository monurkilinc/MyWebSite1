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
    //No:32 : GenericRepository<About>, IAboutDAL ifadesi eklendi.
    
    public class EFAboutRepository : GenericRepository<About>, IAboutDAL
    {
    }
}
