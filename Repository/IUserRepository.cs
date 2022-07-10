using WebApiAutentication.Models;

namespace WebApiAutentication.Repository
{
    public interface IUserRepository
    {
        public User UserLogin (string username, string password);
        public User Register (User user);
        public User Unregister (User user);
    }
}
