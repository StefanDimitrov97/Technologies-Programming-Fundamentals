using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            string pack = Console.ReadLine();

            if (people <= 50)
            {
                if (pack == "Normal")
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 500) - ((2500+500) * 0.05)) / people);
                }
                else if (pack == "Gold")
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 750) - ((2500+750) * 0.1)) / people);
                }
                else if (pack == "Platinum")
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 1000)- ((2500+1000) * 1.5)) / people);
                }
            }
            else if (people > 50 && people <= 100)
            {
                if (pack == "Normal")
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 500) - ((5000 + 500) * 0.05)) / people);
                }
                else if (pack == "Gold")
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 750) - ((5000 + 750) * 0.1)) / people);
                }
                else if (pack == "Platinum")
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 1000) - ((5000 + 1000) * 0.15)) / people);
                }
            }
            else if (people > 100 && people < 120)
            {
                if (pack == "Normal")
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 500) - ((7500 + 500) * 0.05)) / people);
                }
                else if (pack == "Gold")
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 750) - ((7500 + 750) * 0.1)) / people);
                }
                else if (pack == "Platinum")
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 1000) - ((7500 + 1000) * 1.5)) / people);
                }
            }
            else if (people >= 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
