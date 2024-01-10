using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Net.Core.DTOs;
using Web.Net.Core.Models;

namespace Web.Net.Core
{
    public class Mapping
    {
        public UserDto ConvertToUserDto(User user)
        {
            //return new UserDto { Id = user.Id, Name = user.Name, Email = user.Email, Password = user.Password, Plan = user.Plan };

            return new UserDto { Id = user.Id, Name = user.Name, Email = user.Email, Password = user.Password, Plan = new PlanDto { Id = user.Plan.Id, Name = user.Plan.Name, Price = user.Plan.Price } };
        }
    }
}