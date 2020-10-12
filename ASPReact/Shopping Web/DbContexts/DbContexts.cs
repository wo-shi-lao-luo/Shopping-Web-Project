using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.net_version.Models;
using Microsoft.EntityFrameworkCore;

namespace Shopping_Web.DbContexts
{
    public class ShoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database/shopping_web.db");
    }
}
