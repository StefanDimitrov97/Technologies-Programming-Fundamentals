using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_name_2_opit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", helloName(name));
        }

        static string helloName(string firstName)
        {
            return firstName;
        }
    }
}
