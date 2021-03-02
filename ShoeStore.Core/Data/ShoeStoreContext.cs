using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Data
{
    public class ShoeStoreContext : DbContext
    {
        public ShoeStoreContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<ShoeBrand> ShoeBrands { get; set; }
        public DbSet<ShoeCategory> ShoeCategories { get; set; }
        public DbSet<ShoeWidth> ShoeWidths { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerPayment> CustomerPayments { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
