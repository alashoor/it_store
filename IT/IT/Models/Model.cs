namespace IT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Model")]
    public partial class Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model()
        {
            Assets = new HashSet<Asset>();
        }

        public int modelID { get; set; }

        public int? itemID { get; set; }

        [Display(Name = "Model Name")]
        [StringLength(50)]
        public string modelName { get; set; }

        [Display(Name = "Weight")]
        public int? weight { get; set; }

        [Display(Name = "Price")]
        public int? price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }

        public virtual Item Item { get; set; }
    }
}
