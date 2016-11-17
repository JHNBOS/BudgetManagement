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
        public int ID { get; set; }

        [ForeignKey("debiteuren")]
        public int? Deb_ID { get; set; }

        [ForeignKey("producten")]
        public int? Product_ID { get; set; }

        public virtual debiteuren debiteuren { get; set; }

        public virtual producten producten { get; set; }
    }
}
