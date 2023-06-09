using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{ 
	//No:83 AboutService eklenmesi metot düzenlenmesi

	//No:93 IAboutService Generic hale getirilmesi

    public interface IAboutService: IGenericService<About>
    {
		List<About> GetList();
	}
}
