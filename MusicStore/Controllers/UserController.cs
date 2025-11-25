using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Dto;
using MusicStore.Models;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly UserService _UserService = new();
        //get
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_UserService.GetUsers());
        }
        //post
        [HttpPost]
        public IActionResult CraeteUser(CreateUserDto user)
        {
            return Ok(_UserService.CreateUser(user));
        }

        //put

        //delete
    }
}
