namespace IT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            Assets = new HashSet<Asset>();
            RejectionRequests = new HashSet<RejectionRequest>();
        }

        public int locationID { get; set; }

        [Display(Name = "Cost Center")]
        [StringLength(50)]
        public string costCenter { get; set; }

        [Display(Name = "Cost Center Name")]
        [StringLength(50)]
        public string locationName { get; set; }

        [Display(Name = "Unit")]
        [StringLength(50)]
        public string unit { get; set; }

        [Display(Name = "Business Area")]
        [StringLength(50)]
        public string businessArea { get; set; }

        [Display(Name = "Ladies Section")]
        public bool? ladiesSection { get; set; }

        [Display(Name = "Uppur Node Name")]
        [StringLength(50)]
        public string uppurtNodeName { get; set; }

        [Display(Name = "Access Permission")]
        [StringLength(50)]
        public string accessPermission { get; set; }

        [Display(Name = "Distance From Support Node")]
        [StringLength(50)]
        public string distanceFromSupportNode { get; set; }

        [Display(Name = "Classification")]
        [StringLength(50)]
        public string classification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejectionRequest> RejectionRequests { get; set; }
    }
}
