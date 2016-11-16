namespace Invoice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("factuur")]
    public partial class factuur
    {
        public int ID { get; set; }

        public int? Bezit_ID { get; set; }

        public virtual bezit bezit { get; set; }
    }
}
