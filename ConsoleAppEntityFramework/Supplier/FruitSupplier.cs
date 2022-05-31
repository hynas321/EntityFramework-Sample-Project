using ConsoleAppEntityFramework.DbData;

namespace ConsoleAppEntityFramework.Supplier
{
    public class FruitSupplier
    {
        public DbContextSupplier Db { get; }

        public FruitSupplier(DbContextSupplier db)
        {
            Db = db;
        }

        public void AddEmployee(Employee employee)
        {
            Db.Add(employee);
        }

        public void RemoveEmployee(int id)
        {
            Db.Remove(Db.Employees.FirstOrDefault(x => x.Id == id));
        }

        public Employee GetEmployee(int id)
        {
            return Db.Employees.FirstOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return Db.Employees.ToList();
        }

        public void AddInvoice(Invoice invoice)
        {
            Db.Add(invoice);
        }

        public void RemoveInvoice(int id)
        {
            Db.Remove(Db.Invoices.FirstOrDefault(x => x.Id == id));
        }

        public Invoice GetInvoice(int id)
        {
            return Db.Invoices.FirstOrDefault(x => x.Id == id);
        }

        public List<Invoice> GetInvoices()
        {
            return Db.Invoices.ToList();
        }

        public void AddLineItem(LineItem lineItem)
        {
            Db.Add(lineItem);
        }

        public void RemoveLineItem(int id)
        {
            Db.Remove(Db.Employees.FirstOrDefault(x => x.Id == id));
        }

        public LineItem GetLineItem(int id)
        {
            return Db.LineItems.FirstOrDefault(x => x.Id == id);
        }

        public List<LineItem> GetLineItems()
        {
            return Db.LineItems.ToList();
        }

        public void AddProduct(Product product)
        {
            Db.Add(product);
        }

        public void RemoveProduct(int id)
        {
            Db.Remove(Db.Employees.FirstOrDefault(x => x.Id == id));
        }

        public Product GetProduct(int id)
        {
            return Db.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            return Db.Products.ToList();
        }
    }
}
