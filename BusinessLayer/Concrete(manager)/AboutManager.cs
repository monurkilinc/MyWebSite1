using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	//No:83 AboutManager metotların implement edilmesi ve düzenlenmesi
	public class AboutManager : IAboutService
	{
        //No:93 AboutManager implement ettik ve aşağıdaki metotlara ihtiyacımız kalmadı
        //      public AboutManager (IAboutDAL aboutDAL) 
        //{
        //	_aboutDal = aboutDAL;

        //}

        //public List<About> GetList()
        //{
        //	return _aboutDal.GetListAll();
        //}




        IAboutDAL _aboutDal;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDal = aboutDAL;
        }

        //No:93 AboutManager implement ettik ve aşağıdaki metotlar eklendi
        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }


       
    }
}
