using MusicStore.Dto;
using MusicStore.IRepositories;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        //get
        public List<UserDto> GetUsers()
        {
            return _repository.GetUsers();
        }
        //post
        public int CreateUser(CreateUserDto user)
        {
            return _repository.CreateUser(user);
        }
        //put

        //delete

    }
}
