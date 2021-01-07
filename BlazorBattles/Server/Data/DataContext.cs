using BlazorBattles.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorBattles.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        
    }
}
