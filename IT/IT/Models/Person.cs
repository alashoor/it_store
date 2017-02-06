using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IT.Models
{
    public class Person
    {

        public int ID { get; set; } //Or should it be a String? 
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Title")]
        public string title { get; set; }
        [Display(Name = "Department")]
        public string department { get; set; }
        [Display(Name = "Office Number")]
        public string officeNumber { get; set; }
        [Display(Name = "Mobile Number")]
        public string mobileNumber { get; set; }
        [Display(Name = "E-mail")]
        public string email { get; set; }

    }

    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }

}