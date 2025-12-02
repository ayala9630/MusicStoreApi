using MusicStore.Dto;

namespace MusicStore.Servieses
{
    public interface IProductService
    {
        void AddRange(List<CreateProductDto> products);
        bool DeleteProduct(int productId);
        dynamic ProductOrderByTitle();
        dynamic ProductWithCategory();
    }
}