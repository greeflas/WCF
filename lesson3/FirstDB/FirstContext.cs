namespace FirstDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FirstContext : DbContext
    {
        public FirstContext()
            : base("name=FirstContext")
        {
        }

        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>()
                .Property(e => e.val)
                .HasPrecision(19, 4);
        }
    }
}
