using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        //No:104 Navbar dashboard mesaj sınıfı için eklendi
        //List<Message> GetInboxListByWriter(string p);
    }
}
