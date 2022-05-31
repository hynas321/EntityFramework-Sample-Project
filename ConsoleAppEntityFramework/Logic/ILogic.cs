using ConsoleAppEntityFramework.AbstractData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Logic
{
    public interface ILogic
    {
        void AddEmployee(IEmployee employee);
        void RemoveEmployee(int id);
        IEmployee GetEmployee(int id);
        IEnumerable<IEmployee> GetEmployees();

        void AddInvoice(IInvoice invoice);
        void RemoveInvoice(int id);
        IInvoice GetInvoice(int id);
        IEnumerable<IInvoice> GetInvoices();

        void AddLineItem(ILineItem lineItem);
        void RemoveLineItem(int id);
        ILineItem GetLineItem(int id);
        IEnumerable<ILineItem> GetLineItems();

        void AddProduct(IProduct product);
        void RemoveProduct(int id);
        IProduct GetProduct(int id);
        IEnumerable<IProduct> GetProducts();

    }
}
