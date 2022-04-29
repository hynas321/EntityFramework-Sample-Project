using ConsoleAppEntityFramework.DbData;
using ConsoleAppEntityFramework.GenericDbContext;
using ConsoleAppEntityFramework.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework
{
    public interface ISupplier
    {
        public DbContextSupplier Db { get; }
        void SellLineItem(IShop shop, LineItem lineitem, Employee employee);
    }
}
