using AutoMapper;
using Filmweb.Dtos;
using Filmweb.Entities;
using Filmweb.Extensions;
using Filmweb.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Filmweb.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ITokenProvider _tokenProvider;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper, ITokenProvider tokenProvider)
        {
            _userService = userService;
            _mapper = mapper;
            _tokenProvider = tokenProvider;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            var userDtos = _mapper.Map<IList<UserDto>>(users);

            return Ok(userDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            var userDto = _mapper.Map<UserDto>(user);

            return Ok(userDto);
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        // api/user/authenticate
        public IActionResult Authenticate(UserDto userDto)
        {
            User user = _userService.Authenticate(userDto.Email, userDto.Password);

            if (user == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            var model = _mapper.Map<UserDto>(user);
            model.Token = _tokenProvider.GetNew(user.Id);

            return Ok(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(UserDto userDto)
        {
            User user = _mapper.Map<User>(userDto);

            try
            {
                _userService.Create(user, userDto.Password);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPut]
        public IActionResult Update(UserDto userDto)
        {
            User user = _mapper.Map<User>(userDto);
            user.Id = User.Identity.GetUserId();

            try
            {
                _userService.Update(user, userDto.Password);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO only for admin

            _userService.Delete(id);
            return Ok();
        }
    }
}