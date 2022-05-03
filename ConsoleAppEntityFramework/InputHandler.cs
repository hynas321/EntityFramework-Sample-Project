using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework
{
    public static class InputHandler
    {
        public static string[] SetDatabaseInformation(this string[] dbInput)
        {
            if (dbInput.Any())
            {
                Console.WriteLine("Would you like to use the previous database?");
                Console.WriteLine($"Server name: {dbInput[0]}");
                Console.WriteLine($"1st database name: {dbInput[1]}");
                Console.WriteLine($"2nd database name: {dbInput[2]}");
                Console.WriteLine($"[Y/N]");

                char choice = char.ToLower(Console.ReadKey(true).KeyChar);

                switch (choice)
                {
                    case 'y':
                        Console.WriteLine("Database set");
                        break;
                    case 'n':
                        dbInput = GetUserInput();
                        break;
                    default:
                        Console.WriteLine("Incorrect input, please enter database information");
                        dbInput = GetUserInput();
                        break;
                }
            }
            else
            {
                dbInput = GetUserInput();
            }

            return dbInput;
        }

        private static string[] GetUserInput()
        {
            string[] dbInput = new string[3];

            Console.Write("Enter the DB server name: ");
            dbInput[0] = Console.ReadLine();
            Console.Write("Enter the 1st DB's name (shop): ");
            dbInput[1] = Console.ReadLine();
            Console.Write("Enter the 2nd DB's name (supplier): ");
            dbInput[2] = Console.ReadLine();

            return dbInput;
        }
    }
}
