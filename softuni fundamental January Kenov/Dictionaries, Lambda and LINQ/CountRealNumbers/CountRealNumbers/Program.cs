using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    public class Program
    {
       public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse);

            var result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                result[number] = 0;
                }
            result[number]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1} times", item.Key,item.Value);
            }


        }
    }
}
