using KodotiAzureDevOps.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KodotiAzureDevOps.Api.Controllers
{
    [ApiController]
    [Route("/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController() 
        {
            _userService = new UserService();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _userService.Get(id);

            if (result == null) 
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
