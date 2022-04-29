using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Shop
{
    public interface IShop
    {
        DbContextShop Db { get; }
    }
}
 