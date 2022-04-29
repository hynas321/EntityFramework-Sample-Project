using ConsoleAppEntityFramework.DbData;
using ConsoleAppEntityFramework.Shop;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        public static void Main(string[] args)
        {
            IShop shop = new FruitShop(new DbContextShop());
            ISupplier supplier = new FruitSupplier(new DbContextSupplier());

            Employee employee = new Employee() { FullName = "Jan Kowalski", Post = EmployeePost.manager.ToString() };
            Employee employee2 = new Employee() { FullName = "Adam Nowak", Post = EmployeePost.warehouser.ToString() };
            Employee employee3 = new Employee() { FullName = "Kamil Ślimak", Post = EmployeePost.manager.ToString() };

            supplier.Db.Add(employee);
            supplier.Db.Add(employee2);
            shop.Db.Add(employee3);

            Product product = new Product() { Name = "Apple", OriginCountry = "Poland" };
            LineItem lineItem = new LineItem() { Product = product, Count = 100, PriceSum = 100 };

            supplier.Db.Add(product);
            supplier.Db.Add(product);
            supplier.Db.Add(lineItem);
            supplier.Db.Add(lineItem);

            supplier.Db.SaveChanges(true);
            shop.Db.SaveChanges(true);
            Console.WriteLine("Databases saved");
        }
    }
}
