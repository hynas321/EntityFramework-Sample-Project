using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.AbstractData
{
    public interface ILineItem
    {
        public int Id { get; set; }
        public IProduct Product { get; set; }
        public int Count { get; set; }
        public double PriceSum { get; set; }
    }
}
