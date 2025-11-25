using Microsoft.EntityFrameworkCore;
using MusicStore.Data;

namespace BooksApi.Data
{
    public class StoreContextFactory
    {
        private const string ConnectionString = "Server=Srv2\\pupils;DataBase=215635608_musicStore;Integrated Security=SSPI;Persist Security Info=False;TrustServerCertificate=True;";

        public static StoreContext CreateContext()
        {
            var optionsBuilder=new DbContextOptionsBuilder<StoreContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            return new StoreContext(optionsBuilder.Options);
        }
    }
}
