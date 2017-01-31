using System;
using System.Data.Entity;

namespace IT.Models
{
    public class Person
    {

        public int ID { get; set; } //Or should it be a String? 
        public string name { get; set; }
        public string title { get; set; }
        public string department { get; set; }
        public string officeNumber { get; set; }
        public string mobileNumber { get; set; }
        public string email { get; set; }

    }

    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }

}