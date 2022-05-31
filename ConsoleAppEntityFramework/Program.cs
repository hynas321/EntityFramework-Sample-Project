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

            FruitShop shop = new FruitShop(new DbContextShop(dbInfo[0], dbInfo[1]));
            FruitSupplier supplier = new FruitSupplier(new DbContextSupplier(dbInfo[0], dbInfo[2]));

            try
            {
                var shopEmployee = shop.GetEmployee(1);
                var product1 = shop.GetProduct(1);
                var product2 = shop.GetProduct(2);

                var supplierEmployee = supplier.GetEmployee(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /*
             Place for more logic
            */

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
