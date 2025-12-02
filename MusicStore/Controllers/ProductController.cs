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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        //get
        [HttpGet]
        [Route("ProductOrderByTitle")]
        public IActionResult GetByCategory()
        {
            return Ok(_service.ProductOrderByTitle());
        }

        [HttpGet]
        [Route("ProductWithCategory")]
        public IActionResult ProductWithCategory()
        {
            return Ok(_service.ProductWithCategory());
        }
        //post
        [HttpPost]
        public IActionResult Post([FromBody] List<CreateProductDto> products)
        {
            _service.AddRange(products);
            return Ok("success");
        }

        //put
        [HttpPut]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.DeleteProduct(id));
        }

        //delete

    }
}

