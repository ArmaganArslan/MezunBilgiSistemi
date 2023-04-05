using EntityLayer;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BolumValidator : AbstractValidator<Bolum>
    {
        public BolumValidator()
        {
            RuleFor(x => x.ad).NotEmpty().WithMessage("Bölüm Adını Boş Geçemezsiniz");
            RuleFor(x => x.fakulteId).NotNull().WithMessage("Fakülteyi Boş Geçemezsiniz");
            RuleFor(x => x.adres).NotEmpty().WithMessage("Adresi Boş Geçemezsiniz");
            RuleFor(x => x.tel).NotEmpty().WithMessage("Telefonu Boş Geçemezsiniz");
            RuleFor(x => x.mail).NotEmpty().WithMessage("Mail'i Boş Geçemezsiniz");
        }
    }
}
