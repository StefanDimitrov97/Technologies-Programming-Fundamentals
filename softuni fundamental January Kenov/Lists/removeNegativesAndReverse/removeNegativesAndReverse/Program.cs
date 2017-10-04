using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
                numbers.RemoveAll(x => x < 0);
                numbers.Reverse();
                numbers.ForEach(Console.WriteLine);
                if (numbers.Count == 0)
                {
                    Console.WriteLine("empty");
                }
        }
    }
}
