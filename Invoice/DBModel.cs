namespace Invoice
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<bezit> bezit { get; set; }
        public virtual DbSet<debiteuren> debiteuren { get; set; }
        public virtual DbSet<factuur> factuur { get; set; }
        public virtual DbSet<producten> producten { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bezit>()
                .HasMany(e => e.factuur)
                .WithOptional(e => e.bezit)
                .HasForeignKey(e => e.Bezit_ID);

            modelBuilder.Entity<debiteuren>()
                .HasMany(e => e.bezit)
                .WithOptional(e => e.debiteuren)
                .HasForeignKey(e => e.Deb_ID);

            modelBuilder.Entity<producten>()
                .Property(e => e.Prijs)
                .HasPrecision(10, 2);

            modelBuilder.Entity<producten>()
                .HasMany(e => e.bezit)
                .WithOptional(e => e.producten)
                .HasForeignKey(e => e.Product_ID);
        }
    }
}
