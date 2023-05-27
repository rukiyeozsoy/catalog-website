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
    public class CaliscoManager : ICaliscoService
    {
        ICaliscoDal _caliscoDal;
        public CaliscoManager(ICaliscoDal caliscoDal)
        {
            _caliscoDal = caliscoDal;
        }
        public Calisco GetById(int id)
        {
            return _caliscoDal.GetById(id);
        }

        public List<Calisco> GetList()
        {
            return _caliscoDal.GetListAll();
        }
        public List<Calisco> GetCaliscoByID(int id)
        {
            return _caliscoDal.GetListAll(x => x.Calisco_ID == id);
        }

        public void TAdd(Calisco t)
        {
            _caliscoDal.Insert(t);
        }

        public void TDelete(Calisco t)
        {
            _caliscoDal.Delete(t);
        }

        public void TUpdate(Calisco t)
        {
            _caliscoDal.Update(t);
        }
    }
}
