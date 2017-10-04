using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var sum = 0.0;
            sum = a + b;

            Console.WriteLine("{0} + {1} = {2}", a,b,sum);
        }
    }
}
