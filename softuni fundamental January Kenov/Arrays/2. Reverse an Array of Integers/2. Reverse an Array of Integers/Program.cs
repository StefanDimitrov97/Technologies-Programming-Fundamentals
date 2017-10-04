using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            var revursedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                revursedNumbers[i] = numbers[numbers.Length - 1 - i];
                Console.WriteLine(revursedNumbers[i]);
            }
        }
    }
}
