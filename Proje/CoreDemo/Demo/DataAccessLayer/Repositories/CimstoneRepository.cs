using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CimstoneRepository : ICimstoneDal
    {
        Context c = new Context();
        public void Delete(Cimstone t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Cimstone GetById(int id)
        {
            return c.Cimstones.Find(id);
        }

        public List<Cimstone> GetListAll()
        {
            return c.Cimstones.ToList();
        }

        public List<Cimstone> GetListAll(Expression<Func<Cimstone, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cimstone t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Cimstone t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
