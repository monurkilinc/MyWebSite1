using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	//NO:77 IWrıterService den miras aldı ve Generate Constructor yapıldı
	public class WriterManager : IWriterService
	{
		IWriterDAL _writerdal;

		public WriterManager(IWriterDAL writerdal)
		{
			_writerdal = writerdal;
		}

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        //No:100 ID ye göre writer getirmek için aşağıdaki metot eklendi
        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x => x.WriterID == id);
        }

        //No:100 WriterAdd metodu yerine TAdd metodu kullanılacak
        public void TAdd(Writer t)
        {

            _writerdal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }
        //No:101 Yazar profil bilgilerinin getirmek için düzenlendi
        public Writer TGetById(int id)
        {
            return _writerdal.GetByID(id);
        }

        public void TUpdate(Writer t)
        {
            _writerdal.Update(t);
        }

        //nO:100 TAdd metoduna eklediğimiz için artık ihtiyacımız kalmadı
  //      public void WriterAdd(Writer writer)
		//{
		//	_writerdal.Insert(writer);
		//}
	}
}
