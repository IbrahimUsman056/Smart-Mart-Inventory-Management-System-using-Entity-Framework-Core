using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMart_App_EF
{
    public class MartContext:DbContext
    {
        public DbSet<Customers> Cust { get; set; }
        public DbSet<Products> Prod { get; set; }
        public DbSet<SalesRecords> Sal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KUM52JP\\SQLEXPRESS;Initial Catalog=SmartMart;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .HasKey(c => c.CustomerId);
            modelBuilder.Entity<Products>()
                .HasKey(p => p.ProductId);
            modelBuilder.Entity<SalesRecords>()
                .HasKey(s => s.SaleId);

            modelBuilder.Entity<SalesRecords>()
                .HasOne(s => s.Customers)
                .WithMany(c => c.SalesRecord)
       .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<SalesRecords>()
                .HasOne(s => s.Products)
                .WithMany(p => p.SalesRecord)
                .HasForeignKey(s => s.ProductId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
