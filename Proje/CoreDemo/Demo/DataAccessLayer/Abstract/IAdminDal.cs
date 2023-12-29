using EntityLayer.Concrete;


namespace DataAccessLayer.Abstract
{
    public interface IAdminDal : IGenericDal<Admin>
    {
        public string GetByUsername(string username, string Password);
    }
}
