using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.Net.API.Models;
using Web.Net.Core;
using Web.Net.Core.DTOs;
using Web.Net.Core.Models;
using Web.Net.Core.Services;
using Web.Net.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Net.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly Mapping _mapping;

        private readonly IMapper _mapper;
        public UsersController(IUserService userService, Mapping mapping, IMapper mapper)
        {
            _userService = userService;
            _mapping = mapping;
            _mapper = mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _userService.GetAll();
            return Ok(_mapper.Map<List<UserDto>>(list));
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_userService.GetById(id));
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] UserPostModel user)
        {
            var userToAdd = new User { Name = user.Name, Password = user.Password, Email = user.Email, PlanId = user.PlanId };
            var newUser = _userService.Add(userToAdd);
            return Ok(_mapping.ConvertToUserDto(newUser));
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User user)
        {
            return Ok(_userService.Update(id, user));
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var user = _userService.GetById(id);
            if (user is null)
            {
                return NotFound();
            }
            _userService.Delete(id);
            return NoContent();
        }
    }
}
