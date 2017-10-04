using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
           var number = double.Parse(Console.ReadLine());
           if (number >= -9223372036854775808 || number <= 9223372036854775807)
           {
               Console.WriteLine("integer");
           }
           else if (number == )      
           {
               Console.WriteLine("floating-point");
           }
        }
    }
}
