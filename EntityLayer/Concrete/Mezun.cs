using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Mezun
    {
        [Key]
        public int mezunId { get; set; }
        [StringLength(50)]
        public string adSoyad { get; set; }
        [StringLength(100)]
        public string adres { get; set; }
        [StringLength(50)]
        public string tel { get; set; }
        [StringLength(50)]
        public string mail { get; set; }
        public DateTime dogumTarih { get; set; }
        [StringLength(20)]
        public string ogrNo { get; set; }
        [StringLength(20)]
        public string yabanciDil { get; set; }
        public int bolumId { get; set; }
        [StringLength(5)]
        public string baslangicYil { get; set; }
        [StringLength(5)]
        public string bitisYil { get; set; }
        public double ortalama { get; set; }
        [StringLength(50)]
        public string ilgiAlan { get; set; }
        [StringLength(50)]
        public string stajYer { get; set; }
        public virtual Bolum Bolum { get; set; }
    }
}
