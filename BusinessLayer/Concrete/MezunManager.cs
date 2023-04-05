using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MezunManager : IMezunService
    {
        IMezunDal _mezunDal;

        public MezunManager(IMezunDal mezunDal)
        {
            _mezunDal = mezunDal;
        }

        public Mezun GetById(int id)
        {
            return _mezunDal.Get(x => x.mezunId == id);
        }

        public List<Mezun> GetList()
        {
            return _mezunDal.List();
        }

        public void MezunAdd(Mezun mezun)
        {
            _mezunDal.Insert(mezun);
        }

        public void MezunDelete(Mezun mezun)
        {
            _mezunDal.Delete(mezun);
        }

        public void MezunUpdate(Mezun mezun)
        {
            _mezunDal.Update(mezun);
        }
    }
}
