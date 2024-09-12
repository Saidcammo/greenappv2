using GreenAppV2.Model;
using Microsoft.EntityFrameworkCore;

namespace GreenAppV2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
