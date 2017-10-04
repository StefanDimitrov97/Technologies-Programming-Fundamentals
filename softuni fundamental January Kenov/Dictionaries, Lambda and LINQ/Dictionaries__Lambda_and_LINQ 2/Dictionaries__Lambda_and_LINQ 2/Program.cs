using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionaries__Lambda_and_LINQ_2
{
    public class Program
    {
        public static void Main()
        {
            var dictinary = new Dictionary<string, int>();
            dictinary.Add("Ivan", 12);
            dictinary.Add("Gosho", 19);
            dictinary.Add("Maria", 13);

            foreach (var item in dictinary)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dictinary)
            {
                Console.Write(item.Key);
              Console.Write(item.Value);
            }

            //_________________________________________________________

            var sortedDict = new SortedDictionary<string, int>();

            sortedDict["Ivan"] = 6;
            sortedDict["Ana"] = 2;
            sortedDict["Zebra"] = 4;
            sortedDict["Ogi"] = 3;

            foreach (var item in sortedDict)
        	{
        	   Console.WriteLine(item.Key);
               Console.WriteLine(item.Value);
        	}

        }	 
	}
}
