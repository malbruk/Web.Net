using Web.Net.Core.Models;
using Web.Net.Core.Repositories;
using Web.Net.Core.Services;

namespace Web.Net.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User Add(User user)
        {
            return _userRepository.Add(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User? GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User? Update(int id, User user)
        {
            var dbUser = GetById(id);
            if (dbUser == null)
            {
                return null;
            }
            dbUser.Name = user.Name;
            dbUser.Email = user.Email;

            return _userRepository.Update(dbUser);
        }
    }
}