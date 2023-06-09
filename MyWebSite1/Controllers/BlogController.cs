using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MyWebSite1.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
	{
        //NO:49 BM nesnesi türetildi ve EFBlogRepository ile newlendi

        Context c = new Context();
        BlogManager bm =new BlogManager(new EFBlogRepository());
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());

        
        public IActionResult Index()
        {
			//No:55 GetList ifadesi yerine GetBlogListWithCategory ifadesi yazıldı
			var values = bm.GetBlogListWithCategory();//GetList();
            return View(values);
        }

        //No:60 Blog/Index sayfasındaki Devamını Oku butonu için metot tanımlanması ve Add View ile BlogDetails Layoutunun eklenmesi
		public IActionResult BlogReadAll(int id)
        {
            //No:75 id değerine göre girilen blog sayfasında otomatik olarak o bloğa ait yorumların gelmesi için
            //ViewBag.i=id değeri tanımlandı 
            
            ViewBag.i=id;
            var values=bm.GetBlogByID(id);
            return View(values);
        }
        //nO:94 Yazarın kendine ait bloglarını listelemek için oluşturuldu
        [AllowAnonymous]
        public IActionResult BlogListByWriter()
        {
            //No:95 Bloglardan Kategori adının listelenmesi için DÜZENLEDİK
            //var values=bm.GetBlogListByWriter(1);
            //var values = bm.GetListWithCategoryByWriterBM(1);
            //return View(values);

            //No:111 Login Olan Yazarın Bloglarını getirmek için yapıldı
           
            var usermail = User.Identity?.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBM(writerID);
            return View(values);
        }

        //No:94 Yazar panelinden blog eklemek için BlogAdd metodu ekledik

        [AllowAnonymous]
        [HttpGet]
        public IActionResult BlogAdd()
        {
            //No:94 Categorylerin Dropdown List yoluyla BlogAdd sayfasına taşınması

            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString(),
                                                   }).ToList();




            ViewBag.cv = categoryvalues;
            return View();
        }


        //No:94 BusinessLayer/ValidationRules/BlogValidator içinde koyduğumuz kuralları BlogAdd içinde GEÇERLİ olması için 
        // aşağıdaki Validatorları yazdık
        [AllowAnonymous]
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            //No:111 Yeni Blog Ekleme kısmında ID ye göre işlem yapılması için eklendi.Giriş yapan kullanıcının bilgileri otomatik gelicek
            var usermail = User.Identity?.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBM(writerID);

           
            BlogValidator bv = new BlogValidator();

            ValidationResult results = bv.Validate(p);

            
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate =DateTime.Parse(DateTime.Now.ToShortDateString());

                //No:111 writerID yazıldı
                p.WriterID = writerID;

                bm.TAdd(p);
               
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
           
        }

        //No:96 Blog Silme işlemi için metot eklendi
        public IActionResult DeleteBlog(int id)
        {
            var blogvalues=bm.TGetById(id);
            bm.TDelete(blogvalues);

            return RedirectToAction("BlogListByWriter");

        }

        //No:97 Blog düzenleme için eklenen metotlar.List eklendi
        [AllowAnonymous]
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            
            var blogvalues = bm.TGetById(id);


            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {

                                                   Text = x.CategoryName,
                                                   Value=x.CategoryID.ToString(),


                                                    }).ToList();

            
            ViewBag.cv=categoryvalues;
            return View(blogvalues);
        }
        //No:97 Blog düzenleme için eklendi
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            //No:111 Blog güncelleme için kullanıcı girişine göre otomatik olarak bilgilerin gelmesi için yazıldı
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBM(writerID);
            p.WriterID = writerID;

            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true;
            bm.TUpdate(p);

            return RedirectToAction("BlogListByWriter");
            
        }
    }
}
