using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MusicStore.IServices;
using MusicStore.Repositories;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {

        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        //get
        [HttpGet]
        [Route("ProductByCategory")]
        public IActionResult GetByCategory()
        {
            return Ok(_service.ProductByCategory());
        }
        //post

        //put

        //delete

    }
}
