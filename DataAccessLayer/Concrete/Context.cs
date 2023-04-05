using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Fakulte> Fakultes { get; set; }
        public DbSet<Mezun> Mezuns { get; set; }
    }
}
