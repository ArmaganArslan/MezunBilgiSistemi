using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBolumService
    {
        List<Bolum> GetList();
        void BolumAdd(Bolum bolum);
        void BolumDelete(Bolum bolum);
        void BolumUpdate(Bolum bolum);
        Bolum GetById(int id);
    }
}
