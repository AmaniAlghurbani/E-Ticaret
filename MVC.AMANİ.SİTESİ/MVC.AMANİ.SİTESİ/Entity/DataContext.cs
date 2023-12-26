using MVC.AMANİ.SİTESİ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.AMANİ.SİTESİ.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public DbSet<ProductReview> ProductReviews { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Fluent API ile ilişkiyi belirtme
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Reviews)
                .WithRequired(r => r.Product)
                .HasForeignKey(r => r.ProductId);

            base.OnModelCreating(modelBuilder);
        }

    }
}