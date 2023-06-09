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
    //No:103 Generate Constructor =>_notificationDAL(fielddan sonra yapılır)
    public class NotificationManager : INotificationService
    {
        //No:103 INotificationDAL dan _notificationDAL isimli field üretilmesi
         INotificationDAL _notificationDAL;

        public NotificationManager(INotificationDAL notificationDAL)
        {
            _notificationDAL = notificationDAL;
        }
        //No:103 GetList return edildi.(NotificationList.cs de kullanmak için)
        public List<Notification> GetList()
        {
           return _notificationDAL.GetListAll();
        }

        public void TAdd(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
