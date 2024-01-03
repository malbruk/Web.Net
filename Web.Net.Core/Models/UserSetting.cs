using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Net.Core.Models
{
    public class UserSetting
    {
        public int Id { get; set; }

        public string BackgroundColor { get; set; }

        public string FontSize { get; set; }


        public int UserId { get; set; }

        public User User { get; set; }
    }
}
