using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists_video
{
   public class Program
    {
        public static void Main(string[] args)
        {
           
            var listOfNumbers = new List<int>();

            listOfNumbers.Add(10);
            listOfNumbers.Add(20);
            listOfNumbers.Add(30);
            listOfNumbers.Add(40);

            Console.WriteLine(string.Join(", ", listOfNumbers));

            listOfNumbers.Insert(2,50);
            Console.WriteLine(string.Join(", ", listOfNumbers));

            listOfNumbers.Remove(30);
            Console.WriteLine(string.Join(", ", listOfNumbers));

            listOfNumbers.Reverse();
            Console.WriteLine(string.Join(", ", listOfNumbers));

            listOfNumbers.Sort();
            Console.WriteLine(string.Join(", ", listOfNumbers));

            listOfNumbers.Reverse();
            Console.WriteLine(string.Join(", ", listOfNumbers));

         /* bool */ var result =  listOfNumbers.Contains(20); // vrushta bool dali sushtestvuva stoinostta v lista!
            Console.WriteLine(string.Join(", ", listOfNumbers));
            var remove = listOfNumbers.Remove(10);

            Console.WriteLine(remove); // !!

            foreach (var numbers in listOfNumbers)
            {
                Console.WriteLine(numbers);
            }




            var n = int.Parse(Console.ReadLine());
            var secondListOfNUmbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                secondListOfNUmbers.Add(currentNumber);
                secondListOfNUmbers.Sort();
                secondListOfNUmbers.Reverse();
            }
            Console.WriteLine(string.Join(", ", secondListOfNUmbers));


            listOfNumbers.AddRange(secondListOfNUmbers);
            Console.WriteLine(string.Join(", ", listOfNumbers)); // zalepq tvata lista !!
            
        }
    }
}
