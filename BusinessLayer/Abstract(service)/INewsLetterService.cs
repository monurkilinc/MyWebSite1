using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //No:80 ekleme metodu eklendi
     public interface INewsLetterService
    {

        void AddNewsLetter(NewsLetter newsLetter);
    }
}
