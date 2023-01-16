using Microsoft.EntityFrameworkCore;

namespace DotNetCoreReactAdmin_dotnet7.Models
{
    public class DotNetCoreReactAdminContext : DbContext
    {
        public DotNetCoreReactAdminContext(DbContextOptions<DotNetCoreReactAdminContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
