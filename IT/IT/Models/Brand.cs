using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IT.Models
{
    public class Brand
    {

        public int brandID { get; set; }
        [Display(Name = "Brand Name")]
        public string brandName { get; set; }

    }

    public class BrandDBContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
    }

}