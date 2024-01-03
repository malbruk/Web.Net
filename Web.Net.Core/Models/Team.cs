using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Net.Core.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public List<User> Users { get; set; }
    }
}
