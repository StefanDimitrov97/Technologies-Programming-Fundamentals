using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(1, 2, 3));
        }

        static int GetMax (int a, int b, int c)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if (first > second && first > third)
            {
                return first;
            }
            else if (second > first && second > third)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
        
    }
}
