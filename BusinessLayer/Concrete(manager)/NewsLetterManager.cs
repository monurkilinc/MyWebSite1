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
	//No:80 İmplement ettik ve Generete Constructur yaptık(NewsLetterManager üzerinden)
    public class NewsLetterManager:INewsLetterService
    {
        INewsLetterDAL _newsletterDAL;

		public NewsLetterManager()
		{
		}

		public NewsLetterManager(INewsLetterDAL newsletterDAL)
		{
			_newsletterDAL = newsletterDAL;
		}

		//No:80 Ekleme metodunu yazdık

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			_newsletterDAL.Insert(newsLetter);
		}
	}
}
