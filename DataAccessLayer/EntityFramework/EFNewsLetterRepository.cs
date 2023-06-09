using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	//No:80 Generic hale getirildi NewsLetterden miras aldı
	public class EFNewsLetterRepository:GenericRepository<NewsLetter>,INewsLetterDAL
	{
	}
}
