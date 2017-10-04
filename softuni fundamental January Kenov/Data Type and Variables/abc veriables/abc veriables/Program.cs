using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc_veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        char bukva1 = (char)('a' + first);   // От коя буква да подрежда комбинациите в случая са abc, ако 'а' беше 'b' щеше да изведе всички комбинации между bcd
                        char bukva2 = (char)('a' + second);  // От коя буква да подрежда комбинациите в случая са abc, ако 'а' беше 'b' щеше да изведе всички комбинации между bcd
                        char bukva3 = (char)('a' + third);   // От коя буква да подрежда комбинациите в случая са abc, ако 'а' беше 'b' щеше да изведе всички комбинации между bcd
                        Console.Write(bukva1);
                        Console.Write(bukva2);
                        Console.WriteLine(bukva3);
                    }
                   
                }
            }

        }
    }
}
