using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Text;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.DataAccess.Concrete.EntityFramework
{
   public class ECommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ECommerce;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
