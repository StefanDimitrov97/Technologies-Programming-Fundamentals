using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_3.Sum__Min__Max__Average
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                list.Add(numbers);
            }
            Console.WriteLine("Sum = {0}", list.Sum());
            Console.WriteLine("Min = {0}", list.Min());
            Console.WriteLine("Max = {0}", list.Max());
            Console.WriteLine("Average = {0}", list.Average());
        }
    }
}
