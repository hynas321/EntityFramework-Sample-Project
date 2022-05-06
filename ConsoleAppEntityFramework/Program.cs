using ConsoleAppEntityFramework.DbData;
using ConsoleAppEntityFramework.Shop;
using ConsoleAppEntityFramework.Supplier;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        public static void Main(string[] args)
        {
            string server, database1, database2;
            string[] dbInfo;

            if (!File.Exists("savedDB.txt"))
            {
                using (File.Create("savedDB.txt")) { }
            }

            dbInfo = File.ReadLines("savedDB.txt").ToArray();
            dbInfo = dbInfo.SetDatabaseInformation();

            IShop shop = new FruitShop(new DbContextShop(dbInfo[0], dbInfo[1]));
            ISupplier supplier = new FruitSupplier(new DbContextSupplier(dbInfo[0], dbInfo[2]));

            Employee employee = new Employee() { FullName = "Jan Kowalski", Post = EmployeePost.manager.ToString() };
            Employee employee2 = new Employee() { FullName = "Adam Nowak", Post = EmployeePost.warehouser.ToString() };
            Employee employee3 = new Employee() { FullName = "Kamil Ślimak", Post = EmployeePost.manager.ToString() };

            Product product = new Product() { Name = "Apple", OriginCountry = "Poland" };
            LineItem lineItem = new LineItem() { Product = product, Count = 100, PriceSum = 100 };

            supplier.Db.Add(employee);
            supplier.Db.Add(employee2);
            shop.Db.Add(employee3);

            supplier.Db.Add(product);
            supplier.Db.Add(product);
            supplier.Db.Add(lineItem);
            supplier.Db.Add(lineItem);

            try
            {
                supplier.Db.SaveChanges(true);
                shop.Db.SaveChanges(true);
                Console.WriteLine("Databases saved");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }

            File.WriteAllText("savedDB.txt", dbInfo[0] + '\n' + dbInfo[1] + '\n' + dbInfo[2]); ;

        }
    }
}
