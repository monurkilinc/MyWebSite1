using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
            //No:116 Admin Paneli Kategori ekleme sayfasındaki validation rulellar
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adını maksimum 50 karater girebilirsiniz!");
            RuleFor(x => x.CategoryName).MinimumLength(4).WithMessage("Kategori adını minimum 4 karater girebilirsiniz!");


            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz!");
            RuleFor(x => x.CategoryDescription).MaximumLength(300).WithMessage("Kategori açıklaması maksimum 300 karakter girebilirsiniz!");
            RuleFor(x => x.CategoryDescription).MinimumLength(5).WithMessage("Kategori açıklaması minimum 5 karakter girebilirsiniz!");

        
        }

    }
}
