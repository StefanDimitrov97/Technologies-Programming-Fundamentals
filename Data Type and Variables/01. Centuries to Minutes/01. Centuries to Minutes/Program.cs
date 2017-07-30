﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            double days = (int) (365.2422 * years);
            double hours = 24 * days;
            double minutes = 60 * hours;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years , days, hours, minutes);
        }
    }
}
