using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
    

        public Admin GetById(int id)
        {
            return _adminDal.GetById(id);
            
        }

        public List<Admin> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Admin t)
        {
            _adminDal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            _adminDal.Delete(t);
        }

        public void TUpdate(Admin t)
        {
            _adminDal.Update(t);
        }

        public bool ValidateUser(string UserName, string password)
        {
            var user = _adminDal.GetByUsername(UserName, password);

            if (user != null )
            {
                return true; 
            }

            return false; 
        }
    }
}
