using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Net.Core.Models;

namespace Web.Net.Core.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        User Add(User user);

        User Update(int id, User user);

        void Delete(int id);
    }
}
