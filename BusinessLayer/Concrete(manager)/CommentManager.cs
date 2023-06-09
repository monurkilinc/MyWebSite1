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
	//No:70 ICommentService den miras aldık,implement ettik ve aşagıdaki metotlar çağrıldı.
	//_commentdal türetildi ve Comment Manager Generate Constructor ile _commentdal a bağlandi
	public class CommentManager : ICommentService
	{
		ICommentDAL _commentdal;

		public CommentManager(ICommentDAL commentdal)
		{
			_commentdal = commentdal;
		}

		public void CommentAdd(Comment comment)
		{
			//No:81 Bloglara yorum yapabilmek için düzenledik
			_commentdal.Insert(comment);

			//throw new NotImplementedException();
		}

		public List<Comment> GetList(int id)
		{
			return _commentdal.GetListAll(x => x.BlogID == id);
		}
	}
}
