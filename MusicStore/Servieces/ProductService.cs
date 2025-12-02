using MusicStore.Dto;
using MusicStore.IRepositories;
using MusicStore.Models;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        //get
        public dynamic ProductWithCategory()
        {
            return _repository.ProductWithCategory();
        }

        public dynamic ProductOrderByTitle()
        {
            return _repository.ProductOrderByTitle();
        }

        //post
        public void AddRange(List<CreateProductDto> products)
        {
            _repository.AddRange(products);
        }
        //put

        //delete
        public bool DeleteProduct(int productId)
        {
            return _repository.DeleteProduct(productId);
        }
    }
}
