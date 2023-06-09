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
	//No:84 İmplement interface ve generate constructor işlemleri yapıldı
	public class ContactManager : IContactService
	{
		


		IContactDAL _contactDAL;

		public ContactManager(IContactDAL contactDAL)
		{
			_contactDAL=contactDAL;
		}

		public void ContactAdd(Contact contact)
		{
			 _contactDAL.Insert(contact);
		}
	}
}
