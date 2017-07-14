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
            int quantity = int.Parse(Console.ReadLine());
            

            if (professions == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", professions, quantity * 0.70);
            }
            else if (professions == "Businessman" || professions == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", professions, quantity * 1);
            }
            else if (professions == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", professions, quantity * 1.70);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", professions, quantity * 1.20);
            }
        }
    }
}
