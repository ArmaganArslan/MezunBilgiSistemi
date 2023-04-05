using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Fakulte
    {
        [Key]
        public int fakulteId { get; set; }
        [StringLength(50)]
        public string ad { get; set; }
        [StringLength(50)]
        public string adres { get; set; }
        [StringLength(150)]
        public string tel { get; set; }
        [StringLength(50)]
        public string mail { get; set; }

        public ICollection<Bolum> Bolums { get; set; }
    }
}
