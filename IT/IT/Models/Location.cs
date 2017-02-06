using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IT.Models
{
    public class Location
    {

        public int locationID { get; set; }
        [Display(Name = "Location Name")]
        public string locationName { get; set; }
        [Display(Name = "Cost Center")]
        public string costCenter { get; set; }
        [Display(Name = "Unit")]
        public string unit { get; set; }
        [Display(Name = "Business Area")]
        public string businessArea { get; set; }
        [Display(Name = "Ladies Section")]
        public bool ladiesSection { get; set; }
        [Display(Name = "Suppurt Node Name")]
        public string suppurtNodeName { get; set; }
        [Display(Name = "Access Permission")]
        public string accessPermission { get; set; }
        [Display(Name = "Distance From Support Node")]
        public string distanceFromSupportNode { get; set; }
        [Display(Name = "Classification")]
        public string classification { get; set; }

    }

    public class LocationDBContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
    }

}