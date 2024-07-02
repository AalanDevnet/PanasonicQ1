using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanasonicQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("DingDong");
                else if (number % 3 == 0)
                    Console.WriteLine("Ding");
                else if (number % 5 == 0)
                    Console.WriteLine("Dong");
                else
                    Console.WriteLine(number);

                Console.Write("try again? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response == "n")
                {
                    Console.WriteLine("Application closing...");
                    break;
                }
                else if (response != "y")
                {
                    Console.WriteLine("Invalid response. Application closing...");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
