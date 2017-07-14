using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "Octomber")
            {
                if (nights > 7)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (50 * nights) - ((50 * nights) * 0.05));
                    Console.WriteLine("Double: {0:f2} lv.", 65 * nights);
                    Console.WriteLine("Suite: {0:f2} lv.", 75 * nights);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (50 * nights));
                    Console.WriteLine("Double: {0:f2} lv.", 65 * nights);
                    Console.WriteLine("Suite: {0:f2} lv.", 75 * nights);
                }
            }


            else if (month == "September" || month == "Octomber")
            {
                if (nights > 7 && month == "September")
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (60 * nights) - 60);
                    Console.WriteLine("Double: {0:f2} lv.", 72 * nights);
                    Console.WriteLine("Suite: {0:f2} lv.", 82 * nights);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (60 * nights) - 60);
                    Console.WriteLine("Double: {0:f2} lv.", 72 * nights);
                    Console.WriteLine("Suite: {0:f2} lv.", 82 * nights);
                }
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", (60 * nights));
                Console.WriteLine("Double: {0:f2} lv.", 72 * nights);
                Console.WriteLine("Suite: {0:f2} lv.", 82 * nights);
            }

            if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", 60 * nights);
                    Console.WriteLine("Double: {0:f2} lv.", (72 * nights) - ((72 * nights) * 0.1));
                    Console.WriteLine("Suite: {0:f2} lv.", 82 * nights);
                }
              
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                if (nights > 14)
                {
                Console.WriteLine("Studio: {0:f2} lv.", 68 * nights);
                Console.WriteLine("Double: {0:f2} lv.", 77 * nights);
                Console.WriteLine("Suite: {0:f2} lv.", (89 * nights) - ((89 * nights) * 0.15));
                }
                
            }
           
            
            
           
        }
    }
}
