﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
               {    
                
                bool right = true;

                   for (int k = 2; k <= Math.Sqrt(i); k++)
                    {
                        if  (i % k == 0)
                        {
                            right = false;
                            break;
                        }
                    }
                  Console.WriteLine("{0} -> {1}", i, right);
                }
        }
    }
}
