using Microsoft.EntityFrameworkCore;

namespace ShopApi.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public DbSet<ShopItem> ShopItems { get; set; }
    }
}
