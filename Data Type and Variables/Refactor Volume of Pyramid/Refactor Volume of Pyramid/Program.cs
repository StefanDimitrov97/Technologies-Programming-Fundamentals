using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, sum = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            sum = double.Parse(Console.ReadLine());
            sum = (length + width + sum) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", sum);

        }
    }
}
