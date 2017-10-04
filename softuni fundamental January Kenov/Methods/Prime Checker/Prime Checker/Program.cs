using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);
            Console.WriteLine(IsPrime(n));
        }
        static bool IsPrime(long n)
        {
            var isPrime = true;

                if (n == 1 || n == 0)
                {
                    return false;
                }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }

            }
            return isPrime;
        }

    }
}
