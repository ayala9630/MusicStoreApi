using Microsoft.AspNetCore.Mvc;
using MusicStore.IServices;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }
        //get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.OrderList()); 
        }
        //post

        //put

        //delete
    }
}
