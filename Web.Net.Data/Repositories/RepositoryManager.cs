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
    public class RepositoryManager(DataContext context, IRepository<User> userRepository) : IRepositoryManager
    {
        private readonly DataContext _context = context;
        public IRepository<User> Users => userRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
