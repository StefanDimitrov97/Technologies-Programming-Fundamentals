using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videao1___N_числа_от_прав_в_обратен_ред
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine()); // n числа 

            var numbers = new int[numberOfElements]; // Array

            for (int i = 0; i < numbers.Length; i++)
			{
                int currentNumbers = int.Parse(Console.ReadLine());  

                numbers[i] = currentNumbers;    // <- Запис в прав ред
			}

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);   
            }
        }
    }
}
