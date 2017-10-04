using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_5.Short_Words_Sorted
{
     public class Program
    {
        public static void Main()
        {
           Console.ReadLine()
                .ToLower()
                .Split (new [] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '!', '?')}.StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Where(x => x.Length < 5)
                .Distinct()
                .ToList();

            
        }
    }
}
