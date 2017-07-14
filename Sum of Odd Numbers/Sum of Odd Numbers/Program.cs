using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(sum += i);
                    }
                }     
			}
        }
    }
}