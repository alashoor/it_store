using System;
using System.Data.Entity;

namespace IT.Models
{
    public class Location
    {

        public int locationID { get; set; }
        public string locationName { get; set; }
        public string costCenter { get; set; }
        public string unit { get; set; }
        public string businessArea { get; set; }
        public bool ladiesSection { get; set; }
        public string suppurtNodeName { get; set; }
        public string accessPermission { get; set; }
        public string distanceFromSupportNode { get; set; }
        public string classification { get; set; }

    }

    public class LocationDBContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
    }

}