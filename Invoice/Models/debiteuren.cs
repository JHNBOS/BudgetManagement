namespace Invoice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("debiteuren")]
    public partial class debiteuren
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public debiteuren()
        {
            bezit = new HashSet<bezit>();
        }

        public int ID { get; set; }

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public string Straat { get; set; }

        public string Nummer { get; set; }

        public string Postcode { get; set; }

        public string Plaats { get; set; }

        public string Land { get; set; }

        public string Email { get; set; }

        public string Telefoon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bezit> bezit { get; set; }
    }
}
