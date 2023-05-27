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
    public class BelencoRepository : IBelencoDal
    {
        Context c=new Context();
        public void Delete(Belenco t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Belenco GetById(int id)
        {
            return c.Belencos.Find(id);
        }

        public List<Belenco> GetListAll()
        {
            return c.Belencos.ToList();
        }

        public List<Belenco> GetListAll(Expression<Func<Belenco, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Belenco t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Belenco t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
