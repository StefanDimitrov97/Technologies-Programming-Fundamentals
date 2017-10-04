using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); 
            int k = int.Parse(Console.ReadLine());
           var sum = 0;
            var array = new int[n];
            array[0] = 1;
           for (int i = 1; i < array.Length; i++)
           {
               sum = array[i - k - 1];
               array[i] = sum;
               Console.WriteLine(array.Length);
           }
           





        }
    }
}
