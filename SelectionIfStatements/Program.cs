using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a pizza flavour");
            string choice = Console.ReadLine();
            List<string> toppings = new List<string>()
            {
                "meat feast", "pepperoni", "cheese", "chickin", ""
            };


            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
            Console.ReadLine();
        }
    }
}
