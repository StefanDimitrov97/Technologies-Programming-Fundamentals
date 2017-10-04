using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            Console.WriteLine(RevursedNum(number));
        }

        static double RevursedNum(double num)
        {
            var numString = num.ToString(); // 1vo. Prevrushtame double-a v STRING
            var reversedString = string.Empty; // 2ro. Pravim prazna string promenliva. Sled tova q izpozlvame za da naredim bukvite ot cikula taka che poslednata da stane 1-va (4to)!!!!
            for (int i = numString.Length - 1; i >= 0; i--) // 3to. Pravim cikul ot POSLEDNITE BUKVI KUM PURVITE (vinagi e -1 zaradi 0-lata) do >=0 
            { //!!!!!!!!!!!!!!!!!!!! .Lenght - Chrez nego karame cikula da vurti vsqka bukva po duljina ot 0 do kolkoto e dulga dumata.... !!!!!!!!!!!!!!!!!!!!
                reversedString += numString[i]; // 4to. Natrupvame v praznata promenliva (string) bukvite ot poslednata do purvata!!
            }
            var reversedNum = double.Parse(reversedString); // 5to. Prevrushtame string-a v double, kato go Parse-tvame (Parstvame praznata promenliva v koqto sme natrupali v obraten red stringa i go pravim double)
            return reversedNum; // 6.to Vrushtame rezultata 
        }
    }
}
