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
    public class CoanteRepository : ICoanteDal
    {
        Context c = new Context();
        public void Delete(Coante t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Coante GetById(int id)
        {
            return c.Coantes.Find(id);
        }

        public List<Coante> GetListAll()
        {
            return c.Coantes.ToList();
        }

        public List<Coante> GetListAll(Expression<Func<Coante, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Coante t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Coante t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
