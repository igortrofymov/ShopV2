using System;
using System.Collections.Generic;
using System.Text;
using Core.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShopV2.DAL
{
    public class ShopDBContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public ShopDBContext(DbContextOptions<ShopDBContext> options) : base(options)
        {
        }
    }
}
