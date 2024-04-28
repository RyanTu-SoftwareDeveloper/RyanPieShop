using Microsoft.EntityFrameworkCore;

namespace RyanPieShop.Models
{
    public class RyanPieShopDbContext : DbContext
    {
        public RyanPieShopDbContext(DbContextOptions<RyanPieShopDbContext> options) : base(options) 
        { 
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }    
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}

    }
}
