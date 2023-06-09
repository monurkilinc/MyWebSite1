using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	//No:80 Generic hale getirilip NewsLetterdan miras aldı
	public interface INewsLetterDAL:IGenericDAL<NewsLetter>
	{
		
	}
}
