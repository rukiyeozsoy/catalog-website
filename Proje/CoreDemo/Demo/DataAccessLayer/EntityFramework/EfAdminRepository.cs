using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminRepository : GenericRepository<Admin>, IAdminDal
    {
        private readonly Context _context;

        public EfAdminRepository(Context context)
        {
            _context = context;
        }

        public Admin GetByUsername(string username, string Password)
        {
            return _context.Admins.FirstOrDefault(a => a.Username == username);
        }
       

        string IAdminDal.GetByUsername(string username, string Password)
        {
            var admin = _context.Admins.FirstOrDefault(a => a.Username == username);

            if (admin != null)
            {
                
                if (admin.Password == Password)
                {
                    return admin.Username;
                }

            }

            return null;
        }
    }
}
