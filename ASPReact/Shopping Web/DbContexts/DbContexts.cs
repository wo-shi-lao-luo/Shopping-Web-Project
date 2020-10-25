using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shopping_Web.Models.ProductModel;
using Shopping_Web.Models.UserModel;

namespace Shopping_Web.DbContexts
{
    public class ShoppingContext : IdentityDbContext<IdentityUser>
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<UserModel> User { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=database/shopping_web.db");
    }
}