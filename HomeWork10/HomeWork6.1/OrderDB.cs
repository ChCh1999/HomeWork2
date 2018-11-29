namespace HomeWork6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrderDB : DbContext
    {
        public OrderDB()
            : base("name=conn1")
        {}

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.OrderNum)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.TelNum)
                .IsUnicode(false);

            //modelBuilder.Entity<Order>()
            //    .HasOptional(e =>e.OrderDetails)
            //    .WithRequired();

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.OrderNum)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.TypeOfProduct)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.AmountOfProduct);
        }
    }
}
