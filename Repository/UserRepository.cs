using System.Linq;
using System.Threading.Tasks;
using WebApiAutentication.Models;
using WebApiAutentication.UnitofWork;

namespace WebApiAutentication.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly IUnitOfWork _unitOfWork;

        public UserRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public User Register(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Unregister(User user)
        {
            throw new System.NotImplementedException();
        }

        public User UserLogin(string username, string password)
        {
            return _unitOfWork.Context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password && u.State == 1); 
        }
    }
}
