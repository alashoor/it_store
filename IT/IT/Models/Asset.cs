using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IT.Models
{
    public class Asset : Model
    {

        public int assetID { get; set; }
        [Display(Name = "Serial Number")]
        public string serialNumber { get; set; }
        [Display(Name = "Barcode")]
        public string barcode { get; set; }
        [Display(Name = "Service Tag")]
        public string serviceTag { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        [Display(Name = "Remarks")]
        public string remarks { get; set; }
        [Display(Name = "Cost Center")]
        public string costCenter { get; set; }
        [Display(Name = "Timestamp")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime timeStamp { get; set; }

    }

    public class AssetDBContext : DbContext
    {
        public DbSet<Asset> Asset { get; set; }
    }

}