using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Net.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        //Reltionships
        //One-To-Many
        public int PlanId { get; set; }

        public Plan Plan { get; set; }

        //Many-To-Many
        public int TeamId {get;set;}

        public Team Team { get; set; }

        //One-To-One
        public UserSetting UserSetting { get; set; }
    }
}
