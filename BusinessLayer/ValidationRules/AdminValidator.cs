using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator:AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.kullaniciAd).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.sifre).NotEmpty().WithMessage("Şifreyi Boş Geçemezsiniz");
            RuleFor(x => x.mail).NotEmpty().WithMessage("Mail'i Boş Geçemezsiniz");
        }
    }
}
