using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccessLayer.Concrete;
using X.PagedList;
using X.PagedList.Mvc.Core;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace MyWebSite1.Areas.Admin.Controllers
{   
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        //No:114 Admin panelinde kategorilerin listelenmesi için cm nesnesi oluşturduk
       CategoryManager cm=new CategoryManager(new EFCategoryRepository());

        //No:113 [Area()] ifadesiyle oluşturulmuş olan actionların Admin Area sından gelmiş olduğunu sisteme bildirdik("Admin")]
       
        //No:115 Sayfalama işlemi için int page=1 ifadesi eklendi
        public IActionResult Index(int page=1)
        {
            //No:114 Admin panelinde kategorilerin listelenmesi için oluşturduk
            //No:115 Sayfalama işlemi için ToPagedList ifadesi eklendi
            var values = cm.GetList().ToPagedList(page,4);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory() 
        {

            return View();
        }
       
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            //No:116 Category Validatordaki kurallar AddCategoryye aktarıldı
            CategoryValidator cv = new CategoryValidator();

            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                
                cm.TAdd(p);

                return RedirectToAction("Category","Admin");
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
        //No:117 Admin Paneli Pasif Yap butonu silme işlemi
        public IActionResult CategoryDelete(int id)
        {
            var values = cm.TGetById(id);
            cm.TDelete(values);

            return RedirectToAction("Category","Admin");
        }
    }
}
