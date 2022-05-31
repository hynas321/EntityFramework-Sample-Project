using ConsoleAppEntityFramework.DbData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Shop
{
    public class DbContextShop : DbContext
    {
        private string serverName;
        private string databaseName;
        public DbContextShop(string serverName, string databaseName)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server={serverName};Database={databaseName};Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
