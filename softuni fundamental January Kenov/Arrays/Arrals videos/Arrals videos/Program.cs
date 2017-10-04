using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrals_videos
{
    class Program
    {
        static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            var array = new int[numberOfElements];

            for (int i = 0; i < array.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                array[i] = currentNumber;
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
          
        }
    }
}
