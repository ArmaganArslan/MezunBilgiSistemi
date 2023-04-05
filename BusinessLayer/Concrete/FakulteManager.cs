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
    public class FakulteManager : IFakulteService
    {
        IFakulteDal _fakulteDal;

        public FakulteManager(IFakulteDal fakulteDal)
        {
            _fakulteDal = fakulteDal;
        }

        public void FakulteAdd(Fakulte fakulte)
        {
            _fakulteDal.Insert(fakulte);
        }

        public void FakulteDelete(Fakulte fakulte)
        {
            _fakulteDal.Delete(fakulte);
        }

        public void FakulteUpdate(Fakulte fakulte)
        {
            _fakulteDal.Update(fakulte);
        }

        public Fakulte GetById(int id)
        {
            return _fakulteDal.Get(x => x.fakulteId == id);
        }

        public List<Fakulte> GetList()
        {
            return _fakulteDal.List();
        }
    }
}
