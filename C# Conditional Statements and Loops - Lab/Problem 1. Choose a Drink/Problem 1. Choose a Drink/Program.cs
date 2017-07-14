using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string professions = Console.ReadLine();

            if (professions == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (professions == "Businessman" || professions == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (professions == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
