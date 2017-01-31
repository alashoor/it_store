using System;
using System.Data.Entity;

namespace IT.Models
{
    public class Brand
    {

        public int brandID { get; set; }
        public string brandName { get; set; }

    }

    public class BrandDBContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
    }

}