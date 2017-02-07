namespace IT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int personID { get; set; }

        [Display(Name = "Employee ID")]
        public int? employeeID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50)]
        public string name { get; set; }

        [Display(Name = "Title")]
        [StringLength(50)]
        public string title { get; set; }

        [Display(Name = "Department")]
        [StringLength(50)]
        public string department { get; set; }

        [Display(Name = "Office Number")]
        [StringLength(50)]
        public string officeNumber { get; set; }

        [Display(Name = "Mobile Number")]
        [StringLength(50)]
        public string mobileNumber { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(50)]
        public string email { get; set; }
    }
}
