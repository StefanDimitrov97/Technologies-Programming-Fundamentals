using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (k > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", n, k, n * k);
            }

            for (int i = k; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
            }
        }
    }
}