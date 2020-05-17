using BillingManagement.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.UI
{
    class CustomerContext:DbContext
    {    
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlite("Data Source = Customer.db"); // Exemple avec SQLite
            }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
