namespace IT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RejectionRequest
    {
        [Key]
        public int rejectionRequestsID { get; set; }

        [Display(Name = "Serial Number")]
        [StringLength(50)]
        public string serialNumber { get; set; }

        [Display(Name = "Barcode")]
        [StringLength(50)]
        public string barcode { get; set; }

        [Display(Name = "Service Tag")]
        [StringLength(50)]
        public string serviceTag { get; set; }

        [Display(Name = "Business Area")]
        [StringLength(50)]
        public string businessArea { get; set; }

        [Display(Name = "Justification")]
        [StringLength(50)]
        public string justification { get; set; }

        public int? locationID { get; set; }

        [Display(Name = "Timestamp")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "date")]
        public DateTime? timestamp { get; set; }

        public virtual Location Location { get; set; }
    }
}
