﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

           
            minutes = minutes + 30;
            if (minutes > 60)
            {
                minutes = minutes - 60;
                hours++;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", hours,minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
           
        }
    }
}
