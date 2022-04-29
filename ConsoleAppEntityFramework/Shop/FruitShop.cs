using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Shop
{
    public class FruitShop : IShop
    {
        public DbContextShop Db { get; }

        public FruitShop(DbContextShop db)
        {
            Db = db;
        }
    }
}
