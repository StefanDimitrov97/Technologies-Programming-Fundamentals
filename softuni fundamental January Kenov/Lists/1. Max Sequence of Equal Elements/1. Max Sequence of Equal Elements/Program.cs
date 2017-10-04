using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main()
        {
            var number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var list = new List<int>();

            var max = 0;
        

            for (int i = 0; i < number.Count; i++)
            {
                max = number.Max();
            }
            Console.WriteLine(max);
            

           


        }
    }
}
