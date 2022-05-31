using ConsoleAppEntityFramework.DbData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.AbstractData
{
    public interface IInvoice
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime DateTime { get; set; }
        public ILineItem LineItem { get; set; }
        public IEmployee IssuedBy { get; set; }
    }
}
