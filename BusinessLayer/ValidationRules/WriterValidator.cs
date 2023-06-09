using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            //No:78 Register işleminde kullanıcıların dikkat etmesi gereken kuralları koyduk
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar adı-soyadı kısmı boş geçilemez!!!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez!!!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez!!!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakterli isim girişi yapın!!!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterli isim girişi yapın!!!");

        }
    }
}
