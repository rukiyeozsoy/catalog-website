using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CoanteManager : ICoanteService
    {
        ICoanteDal _coanteDal;
        public CoanteManager(ICoanteDal coanteDal)
        {
            _coanteDal = coanteDal;
        }
        public Coante GetById(int id)
        {
            return _coanteDal.GetById(id);
        }

        public List<Coante> GetCoanteByID(int id)
        {
            return _coanteDal.GetListAll(x => x.Coante_ID == id);
        }
        public List<Coante> GetList()
        {
            return _coanteDal.GetListAll();
        }

        public void TAdd(Coante t)
        {
            _coanteDal.Insert(t);
        }

        public void TDelete(Coante t)
        {
            _coanteDal.Delete(t);
        }

        public void TUpdate(Coante t)
        {
            _coanteDal.Update(t);
        }
    }
}
