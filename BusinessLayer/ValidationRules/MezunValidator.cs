using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MezunValidator : AbstractValidator<Mezun>
    {
        public MezunValidator()
        {
            RuleFor(x => x.adSoyad).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.adres).NotEmpty().WithMessage("Adresi Boş Geçemezsiniz");
            RuleFor(x => x.tel).NotEmpty().WithMessage("Telefonu Boş Geçemezsiniz");
            RuleFor(x => x.mail).NotEmpty().WithMessage("Mail'i Boş Geçemezsiniz");
            RuleFor(x => x.dogumTarih).NotEmpty().WithMessage("Doğum Tarihini Boş Geçemezsiniz");
            RuleFor(x => x.ogrNo).NotEmpty().WithMessage("Öğrenci Numarasını Boş Geçemezsiniz");
            RuleFor(x => x.yabanciDil).NotEmpty().WithMessage("Yabancı Dili Boş Geçemezsiniz");
            //RuleFor(x => x.bolumId).NotEmpty().WithMessage("Bölümü Boş Geçemezsiniz");
            RuleFor(x => x.baslangicYil).NotEmpty().WithMessage("Başlangıç Yılını Boş Geçemezsiniz");
            RuleFor(x => x.bitisYil).NotEmpty().WithMessage("Bitiş Yılını Boş Geçemezsiniz");
            RuleFor(x => x.ortalama).NotEmpty().WithMessage("Ortalamayı Boş Geçemezsiniz");
            RuleFor(x => x.ilgiAlan).NotEmpty().WithMessage("İlgi Alanını Boş Geçemezsiniz");
        }
    }
}
