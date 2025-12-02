using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Dto;
using MusicStore.IServices;
using MusicStore.Models;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        //get
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_service.GetUsers());
        }
        //post
        [HttpPost]
        public IActionResult CraeteUser(CreateUserDto user)
        {
            return Ok(_service.CreateUser(user));
        }

        //put

        //delete
    }
}
