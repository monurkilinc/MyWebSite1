using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	//No:100 IWriterService generic hale getirildi
    public interface IWriterService:IGenericService<Writer>
    {
        //No:100 WriterManager Refactoring yapılınca WriterAdd metodu yerine TAdd metodunu kullanacağız.WriterAdd e ihtiyacımız kalmadı

                ////No:77 Üye olmak için WriterAdd metodu tanımlandı
                //void WriterAdd(Writer writer);

        //No:100 Yazar ID sine göre işlem yapabilme için aşağıdaki metot tanımlandı
        List<Writer> GetWriterById(int id);
    }
}
