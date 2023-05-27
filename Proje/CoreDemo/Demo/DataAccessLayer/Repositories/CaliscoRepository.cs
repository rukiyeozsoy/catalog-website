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
    public class CaliscoRepository : ICaliscoDal
    {
        Context c = new Context();
        public void Delete(Calisco t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Calisco GetById(int id)
        {
            return c.Caliscos.Find(id);
        }

        public List<Calisco> GetListAll()
        {
            return c.Caliscos.ToList();
        }

        public List<Calisco> GetListAll(Expression<Func<Calisco, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Calisco t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Calisco t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
