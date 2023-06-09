using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2DAL : IGenericDAL<Message2>
    {
        //No:108 Yazara gelen mesajların include edilmesi işlemi için yazıldı.(Yazara gelen mesajların include edilmesi işlemi için yazıldı)
        List<Message2> GetListWithMessageByWriter(int id);
    }
}
