using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.English_Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            englishName(num); // vikam metoda purvo zaduljitelno s INPUTA!

            switch (englishName(Math.Abs(num))) // // pokazvam na logikata (2riqt metod) kakvo da otpechatva sa suotvetniq ochakvan rezultat ot logikata PRILOJENA S INPUT-A
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default:
                    break;
            } 
        }

        static long englishName(long number) // izmislqm logikata vuv 2riqt metod kato davam proizvolna moq promenliva (v sluchaq long number) i v Maina my kazvam da izvurshva sushtata logika kakto (vuv sluchaq long number) samo che da go pravi s INPUTA v Main-a (v sluchaq num)
        {
            long lastNumber = number % 10; // realno logikata, koqto iziskva vrushtane na sledvashtiqt red vinagi !

            return lastNumber; // karam go da vurne rezultata!
        }
    }
}
