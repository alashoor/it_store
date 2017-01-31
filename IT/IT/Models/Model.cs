using System;
using System.Data.Entity;

namespace IT.Models
{
    public class Model : Item
    {

        public int modelID { get; set; }
        public string modelName { get; set; }
        public double weight { get; set; }
        public int price { get; set; }

    }

    public class ModelDBContext : DbContext
    {
        public DbSet<Model> Model { get; set; }
    }

}