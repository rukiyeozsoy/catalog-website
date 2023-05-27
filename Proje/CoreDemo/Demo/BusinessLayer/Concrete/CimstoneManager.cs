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
    public class CimstoneManager : ICimstoneService
    {
        ICimstoneDal _cimstoneDal;
        public CimstoneManager(ICimstoneDal cimstoneDal)
        {
            _cimstoneDal = cimstoneDal;
        }
        public Cimstone GetById(int id)
        {
            return _cimstoneDal.GetById(id);
        }
        public List<Cimstone> GetCimstoneByID(int id)
        {
            return _cimstoneDal.GetListAll(x => x.Cimstone_ID == id);
        }

        public List<Cimstone> GetList()
        {
            return _cimstoneDal.GetListAll();
        }

        public void TAdd(Cimstone t)
        {
            _cimstoneDal.Insert(t);
        }

        public void TDelete(Cimstone t)
        {
            _cimstoneDal.Delete(t);
        }

        public void TUpdate(Cimstone t)
        {
            _cimstoneDal.Update(t);
        }
    }
}
