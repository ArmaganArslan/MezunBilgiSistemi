using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Admin
    {
        [Key]
        public int adminId { get; set; }
        [StringLength(20)]
        public string kullaniciAd { get; set; }
        [StringLength(20)]
        public string sifre { get; set; }
        [StringLength(20)]
        public string mail { get; set; }
    }
}
