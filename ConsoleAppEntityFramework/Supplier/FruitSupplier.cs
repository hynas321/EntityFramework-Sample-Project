using ConsoleAppEntityFramework.DbData;
using ConsoleAppEntityFramework.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Supplier
{
    public class FruitSupplier : ISupplier
    {
        public DbContextSupplier Db { get; }

        public FruitSupplier(DbContextSupplier db)
        {
            Db = db;
        }
        public void SupplyLineItem(IShop shop, LineItem lineItem, Employee employee)
        {
            //No implementation yet
        }
    }
}
