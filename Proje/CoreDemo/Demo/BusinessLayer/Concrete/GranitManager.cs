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
    public class GranitManager : IGranitService
    {
        IGranitDal _granitDal;
        public GranitManager(IGranitDal granitDal)
        {
            _granitDal = granitDal;
        }
        public Granit GetById(int id)
        {
            return _granitDal.GetById(id);
        }

        public List<Granit> GetGranitByID(int id)
        {
            return _granitDal.GetListAll(x => x.Granit_ID == id);
        }
        public List<Granit> GetList()
        {
            return _granitDal.GetListAll();
        }

        public void TAdd(Granit t)
        {
            _granitDal.Insert(t);
        }

        public void TDelete(Granit t)
        {
            _granitDal.Delete(t);
        }

        public void TUpdate(Granit t)
        {
            _granitDal.Update(t);
        }
    }
}
