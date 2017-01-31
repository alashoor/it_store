using System;
using System.Data.Entity;

namespace IT.Models
{
    public class Asset
    {

        public string serialNumber { get; set; }
        public string barcode { get; set; }
        public string serviceTag { get; set; }
        public string status { get; set; }
        public string remarks { get; set; }
        public string costCenter { get; set; }
        public DateTime timeStamp { get; set; }

    }

    public class AssetDBContext : DbContext
    {
        public DbSet<Asset> Asset { get; set; }
    }

}