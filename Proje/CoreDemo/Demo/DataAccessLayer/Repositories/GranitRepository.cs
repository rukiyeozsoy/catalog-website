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
    public class GranitRepository : IGranitDal
    {
        Context c = new Context();
        public void Delete(Granit t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Granit GetById(int id)
        {
            return c.Granits.Find(id);
        }

        public List<Granit> GetListAll()
        {
            return c.Granits.ToList();
        }

        public List<Granit> GetListAll(Expression<Func<Granit, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Granit t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Granit t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
