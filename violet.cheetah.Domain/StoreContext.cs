using Violet.Cheetah.Domain.Catalog;  // Assuming Catalog is your actual namespace
using Microsoft.EntityFrameworkCore;

namespace violet.cheetah.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
