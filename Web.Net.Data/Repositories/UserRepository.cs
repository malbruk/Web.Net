using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Net.Core.Models;
using Web.Net.Core.Repositories;

namespace Web.Net.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.Include(u => u.Plan);
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public User Update(int id, User user)
        {
            var existUser = GetById(id);

            existUser.Name = user.Name;
            existUser.Email = user.Email;

            _context.SaveChanges();
            return existUser;
        }
    }
}
