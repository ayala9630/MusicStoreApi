using MusicStore.Dto;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class UserService
    {
        private readonly UserRepository _repository = new();

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
