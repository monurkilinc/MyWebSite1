using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        //No:84 ContactAdd tanımlanması ve parametreler
        void ContactAdd(Contact contact);

    }
}
