using Microsoft.EntityFrameworkCore;

namespace ModelsLibrairy
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Merchant> Merchant { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Variant> Variant { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
