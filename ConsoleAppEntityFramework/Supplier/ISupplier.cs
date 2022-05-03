using ConsoleAppEntityFramework.DbData;
using ConsoleAppEntityFramework.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Supplier
{
    public interface ISupplier
    {
        public DbContextSupplier Db { get; }
        void SupplyLineItem(IShop shop, LineItem lineitem, Employee employee);
    }
}
