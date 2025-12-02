using MusicStore.Dto;

namespace MusicStore.Servieses
{
    public interface IUserService
    {
        int CreateUser(CreateUserDto user);
        List<UserDto> GetUsers();
    }
}