using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Net.Core.Models;

namespace Web.Net.Core.Repositories
{
    public interface IRepositoryManager
    {
        IRepository<User> Users { get; }
       
        void Save();
    }
}
