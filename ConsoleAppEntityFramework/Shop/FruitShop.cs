using ConsoleAppEntityFramework.AbstractData;
using ConsoleAppEntityFramework.DbData;
using ConsoleAppEntityFramework.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Shop
{
    public class FruitShop : ILogic
    {
        public DbContextShop Db { get; }

        public FruitShop(DbContextShop db)
        {
            Db = db;
        }

        public void AddEmployee(IEmployee employee)
        {
            Db.Add(employee);
        }

        public void RemoveEmployee(int id)
        {
            Db.Remove(Db.Employees.FirstOrDefault(x => x.Id == id));
        }

        public IEmployee GetEmployee(int id)
        {
            return Db.Employees.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<IEmployee> GetEmployees()
        {
            return Db.Employees.ToList();

        }

        public void AddInvoice(IInvoice invoice)
        {
            Db.Add(invoice);
        }

        public void RemoveInvoice(int id)
        {
            Db.Remove(Db.Invoices.FirstOrDefault(x => x.Id == id));
        }

        public IInvoice GetInvoice(int id)
        {
            return (IInvoice)Db.Invoices.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<IInvoice> GetInvoices()
        {
            return (IEnumerable<IInvoice>)Db.Invoices.ToList();
        }

        public void AddLineItem(ILineItem lineItem)
        {
            Db.Add(lineItem);
        }

        public void RemoveLineItem(int id)
        {
            Db.Remove(Db.Employees.FirstOrDefault(x => x.Id == id));
        }

        public ILineItem GetLineItem(int id)
        {
            return (ILineItem)Db.LineItems.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<ILineItem> GetLineItems()
        {
            return (IEnumerable<ILineItem>)Db.LineItems.ToList();
        }

        public void AddProduct(IProduct product)
        {
            Db.Add(product);
        }

        public void RemoveProduct(int id)
        {
            Db.Remove(Db.Employees.FirstOrDefault(x => x.Id == id));
        }

        public IProduct GetProduct(int id)
        {
            return (IProduct)Db.Products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<IProduct> GetProducts()
        {
            return (IEnumerable<IProduct>)Db.Products.ToList();
        }
    }
}
