using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int sum = 0; 
            int howMuch = 0; 
            bool toe = false;
            
            for (int i = 1; i <= num; i++)
            {
                howMuch = i;
                while (i > 0)
            {

        sum += i % 10;
        i = i / 10;
    }
    toe = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}",howMuch,toe);
    sum = 0;
    i = howMuch;
}

        }
    }
}
