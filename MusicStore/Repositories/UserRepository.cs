using BooksApi.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Dto;
using MusicStore.Models;

namespace MusicStore.Repositories
{
    public class UserRepository
    {
        StoreContext context = StoreContextFactory.CreateContext();
        //get
        public List<UserDto> GetUsers()
        {
            return context.Users.Select(x => new UserDto() { Name = x.Name, Username = x.Username }).ToList();
        }
        //post
        public int CreateUser(CreateUserDto user)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                var outputParameter = new SqlParameter
                {
                    ParameterName = "@Id",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Output
                };
                var parameters = new[]
                {
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@Username",user.Username),
                new SqlParameter("@password",user.Password),
                outputParameter
            };


                context.Database.ExecuteSqlRaw("EXEC CreateUser @Name, @Username, @Password, @Id OUTPUT", parameters);

                int userId = (int)outputParameter.Value;

                context.Database.ExecuteSqlInterpolated($@"EXEC UpdateUser @id={userId}, @Password={user.Password + '!'}");

                transaction.Commit();
                return userId;
            }
            catch
            {
                transaction.Rollback();
            }
            return 0;

        }
        //put

        //delete
    }
}
