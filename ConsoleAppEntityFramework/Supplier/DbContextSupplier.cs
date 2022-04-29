using ConsoleAppEntityFramework.DbData;
using ConsoleAppEntityFramework.GenericDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework
{
    public class DbContextSupplier : DbContext, IDbContext
    {
        private string serverName = "DESKTOP-FPKKAFK";
        private string databaseName = "Supplier";
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> ProductTypes { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server={serverName};Database={databaseName};Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
