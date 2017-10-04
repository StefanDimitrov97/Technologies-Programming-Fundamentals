using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_4.Largest_3_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            numbers.Reverse();
           
            Console.WriteLine(string.Join(" ", numbers.Take(3)));
        }
    }
}
