using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BolumManager : IBolumService
    {
        IBolumDal _bolumDal;

        public BolumManager(IBolumDal bolumDal)
        {
            _bolumDal = bolumDal;
        }

        public void BolumAdd(Bolum bolum)
        {
            _bolumDal.Insert(bolum);
        }

        public void BolumDelete(Bolum bolum)
        {
            _bolumDal.Delete(bolum);
        }

        public void BolumUpdate(Bolum bolum)
        {
            _bolumDal.Update(bolum);
        }

        public Bolum GetById(int id)
        {
            return _bolumDal.Get(x => x.bolumId == id);
        }

        public List<Bolum> GetList()
        {
            return _bolumDal.List();
        }
    }
}
