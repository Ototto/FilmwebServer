using Filmweb.Dtos;
using Filmweb.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Filmweb.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private FilmwebContext _context;

        public UserController(FilmwebContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("GetAll");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(id);
        }

        [HttpPost("authenticate")] // api/user/authenticate
        public string Authenticate(UserDto userDto)
        {
            return "Authorizuje";
        }

        [AllowAnonymous]
        [HttpPost]
        public string Register()
        {
            return "Zwracam anonimowym";
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UserDto userDto)
        {
            return Ok("Updated " + id + " imie ziomka: " + userDto.Name);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Deleted " + id);
        }

    }
}