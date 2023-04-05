using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bolum
    {
        [Key]
        public int bolumId { get; set; }
        public int fakulteId { get; set; }
        [StringLength(50)]
        public string ad { get; set; }
        [StringLength(50)]
        public string adres { get; set; }
        [StringLength(50)]
        public string tel { get; set; }
        [StringLength(50)]
        public string mail { get; set; }

        public virtual Fakulte Fakulte { get; set; }

        public ICollection<Mezun> Mezuns { get; set; }
    }
}
