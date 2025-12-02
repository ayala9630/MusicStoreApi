using MusicStore.Dto;
using MusicStore.IRepositories;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }
        //get
        public List<OrdersDto> OrderList()
        {
            return _repository.OrederList();
        }
        //post

        //put

        //delete
    }
}
