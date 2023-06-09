using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite1.ViewComponents.Writer
{
    //No:100 DashBoardda WriterAbout kısmı için eklenen class ve metotların yazılması
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriteRepository());
        //No:101 Login olan yazarın bilgilerinin gelmesi için context c eklendi,usermail ve writerID tanımlandı ve GetWriterById içinde writerID çağrıldı
        //No:101 Bu sayede giriş yapan kullanıcıya ait Dashboard Yazar Hakkında kısmında onun bilgileri gelecek
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
           
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            //No:100 Yazar ID ye göre işlem yapmak için eklendi
            var values =wm.GetWriterById(writerID);
            return View(values);
        }


    }
}
