using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacciNum(n));
        }

        static int fibonacciNum(int number)
        {
            int counter = 1;

            for (int i = 0; i <= number; i++)
            {
                counter += i;
            }
            return counter;
        }
    }
}
