using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	//No:69 CommentAdd ve Comment GetList metotlarının eklenmesi
    public interface ICommentService
    {
		void CommentAdd(Comment comment);
		//void CategoryDelete(Category category);
		//void CategoryUpdate(Category category);

		List<Comment> GetList(int id);
		//Category GetById(int id);
	}
}
