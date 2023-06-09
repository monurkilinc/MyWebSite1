﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2DAL _messageDal;

        public Message2Manager(IMessage2DAL messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            //No:107 ReceiverID olarak değiştirildi
            //No:108  Altta yorum satırı haline getirilen yer yerine aşağıdaki metot yazıldı
            return _messageDal.GetListWithMessageByWriter(id);
                
                /*GetListAll(x => x.ReceiverID == id);*/
        }

        public List<Message2> GetList()
        {
            return _messageDal.GetListAll();
        }


        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            return _messageDal.GetByID(id);
        }


        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }

        List<Message2> IGenericService<Message2>.GetList()
        {
            throw new NotImplementedException();
        }

        Message2 IGenericService<Message2>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}