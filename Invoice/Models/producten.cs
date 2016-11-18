namespace Invoice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("producten")]
    public partial class producten
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producten()
        {
            bezit = new HashSet<bezit>();
            factuur = new HashSet<factuur>();
        }

        public int ID { get; set; }

        public string Naam { get; set; }

        public string Beschrijving { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Prijs { get; set; }

        public int? BTW { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bezit> bezit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factuur> factuur { get; set; }
    }
}
