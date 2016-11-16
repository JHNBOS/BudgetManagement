namespace Invoice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bezit")]
    public partial class bezit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bezit()
        {
            factuur = new HashSet<factuur>();
        }

        public int ID { get; set; }

        public int? Deb_ID { get; set; }

        public int? Product_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factuur> factuur { get; set; }

        public virtual debiteuren debiteuren { get; set; }

        public virtual producten producten { get; set; }
    }
}
