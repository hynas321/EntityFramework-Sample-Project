using ConsoleAppEntityFramework.DbData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.GenericDbContext
{
    public interface IDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> ProductTypes { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
