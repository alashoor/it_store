namespace IT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Asset")]
    public partial class Asset
    {
        [Key]
        public int assetlID { get; set; }

        public int? modelID { get; set; }

        [Display(Name = "SerialNumber")]
        [StringLength(50)]
        public string serialNumber { get; set; }

        [Display(Name = "Barcode")]
        [StringLength(50)]
        public string barcode { get; set; }

        [Display(Name = "SeviceTag")]
        [StringLength(50)]
        public string seviceTag { get; set; }

        [Display(Name = "Status")]
        [StringLength(50)]
        public string status { get; set; }

        [Display(Name = "Remarks")]
        [StringLength(50)]
        public string remarks { get; set; }

        [Display(Name = "Cost Center")]
        public int? locationID { get; set; }

        [Display(Name = "Timestamp")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "date")]
        public DateTime? timestamp { get; set; }

        public virtual Location Location { get; set; }

        public virtual Model Model { get; set; }
    }
}
