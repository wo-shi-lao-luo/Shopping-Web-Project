using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.net_version.Models;
using Microsoft.EntityFrameworkCore;
using Shopping_Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Shopping_Web.DbContexts
{
    public class ShoppingContext : IdentityDbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<UserModel> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database/shopping_web.db");
    }
}
