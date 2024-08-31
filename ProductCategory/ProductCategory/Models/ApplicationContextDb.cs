using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductCategory.Models
{
    public class ApplicationContextDb : DbContext
    {
        public ApplicationContextDb(): base("name=YourDbContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}