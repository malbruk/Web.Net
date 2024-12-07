using Web.Net.Core.Models;
using Web.Net.Core.Repositories;
using Web.Net.Core.Services;

namespace Web.Net.Service
{
    public class UserService(IRepositoryManager repositoryManager) : IUserService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;

        public User Add(User user)
        {
            _repositoryManager.Users.Add(user);
            _repositoryManager.Save();
            return user;
        }

        public void Delete(User user)
        {
            _repositoryManager.Users.Delete(user);
            _repositoryManager.Save();
        }

        public IEnumerable<User> GetAll()
        {
            return _repositoryManager.Users.GetAll();
        }

        public User? GetById(int id)
        {
            return _repositoryManager.Users.GetById(id);
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

            _repositoryManager.Users.Update(dbUser);
            _repositoryManager.Save();
            return dbUser;
        }
    }
}