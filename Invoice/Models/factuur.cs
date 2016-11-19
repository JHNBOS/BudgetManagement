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

        [ForeignKey("debiteuren")]
        public int? Deb_ID { get; set; }

        [ForeignKey("producten")]
        public int? Product_ID { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:#,###0.00}", ApplyFormatInEditMode = true)]
        public decimal? Prijs { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Datum { get; set; }

        public virtual debiteuren debiteuren { get; set; }

        public virtual producten producten { get; set; }
    }
}
