using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IT.Models
{
    public class Model : Item
    {

        public int modelID { get; set; }
        [Display(Name = "Model Name")]
        public string modelName { get; set; }
        [Display(Name = "Weight")]
        public double weight { get; set; }
        [Display(Name = "Price")]
        public int price { get; set; }

    }

    public class ModelDBContext : DbContext
    {
        public DbSet<Model> Model { get; set; }
    }

}