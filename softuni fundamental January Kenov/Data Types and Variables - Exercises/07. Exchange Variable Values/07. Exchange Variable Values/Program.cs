using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            int d = 0;
            #region Before:
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            #endregion

            #region After:
            Console.WriteLine("After:");

            c = a;
            d = b;
            a = d;
            b = c;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            #endregion

        }
    }
}
