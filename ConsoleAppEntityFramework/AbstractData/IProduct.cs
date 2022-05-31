using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.AbstractData
{
    public interface IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OriginCountry { get; set; }
    }
}
