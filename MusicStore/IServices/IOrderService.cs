using MusicStore.Dto;

namespace MusicStore.Servieses
{
    public interface IOrderService
    {
        List<OrdersDto> OrderList();
    }
}