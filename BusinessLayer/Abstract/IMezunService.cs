using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMezunService
    {
        List<Mezun> GetList();
        void MezunAdd(Mezun mezun);
        void MezunDelete(Mezun mezun);
        void MezunUpdate(Mezun mezun);
        Mezun GetById(int id);
    }
}
