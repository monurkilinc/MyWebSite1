using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessage2Service : IGenericService<Message2>
    {
        //No:107 Yazara ait mesaj bildirimleri için eklendi
        List<Message2> GetInboxListByWriter(int id);

       
    }
}
