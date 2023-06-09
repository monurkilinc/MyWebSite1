using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //NO:31 Generic hale getirilmesi
    public interface IWriterDAL:IGenericDAL<Writer>
    {
    }
}
