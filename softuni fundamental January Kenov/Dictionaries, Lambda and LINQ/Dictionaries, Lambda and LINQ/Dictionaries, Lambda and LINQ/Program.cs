using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries__Lambda_and_LINQ
{
    public class Program
    {
       public static void Main()
        {
           var arr = new int[10];
           arr[2] = 100;
           Console.WriteLine(arr[2]);

           //--------------------------------------
           Console.WriteLine("____________________________________-");

           var dictinary = new Dictionary<string, int>(); // Искам индекса да ми е string, a стойностите,
                                                          //които ще паззя вътре да са int 
           dictinary["Pesho"] = 5;
           dictinary["Gosho"] = 5;
           dictinary["Ivan"] = 3; // ocenki // За всеки string отговаря определен int 
           Console.WriteLine(dictinary["Pesho"]); // 5;
           Console.WriteLine("____________________________________-");

           //--------------------------------------------------------------------------------

           var phones = new Dictionary<string, string>();
           phones["Pesho"] = "+3599658965";
           phones["Georgi Georgiev"] = "+3599896265";
           dictinary["Pesho"] = 100;
           Console.WriteLine(dictinary["Pesho"]); // презаписва се новата стойност
           Console.WriteLine("____________________________________-");
           //_________________________________________________________________________

           bool exists = dictinary.ContainsKey("Maria"); // Проверява дали мариа съществува в речника
           Console.WriteLine(exists);
           Console.WriteLine("____________________________________-");
           //__________________________________________

           Console.WriteLine(dictinary.Count); // колко стойности имам в тази променлива с име dictinary
           Console.WriteLine("____________________________________-");
           var keys = dictinary.Keys; // Да ми изведе  в речника на име dictinary какви key-s (имена имам в този речник)
           foreach (var key in keys)
           {
               Console.WriteLine(key);
           }
           Console.WriteLine("____________________________________-");
           foreach (var item in dictinary)
           {
               Console.WriteLine(item); // [Pesho, 100], [Gosho, 5], [Ivan, 3];
           }
           Console.WriteLine("____________________________________-");
           foreach (var item in dictinary)
           {
               Console.WriteLine(item.Key);// pesho , gosho, ivan
               Console.WriteLine(item.Value);// 100 ,   5,     3
           }
           Console.WriteLine("____________________________________-");
           foreach (var item in dictinary.Reverse())
           {
               Console.WriteLine(item.Key);// ivan , gosho, pesjo
               Console.WriteLine(item.Value);// 3 ,   5,    100
           }
           //_______________________________________________________
           Console.WriteLine("____________________________________-");
           var values = dictinary.Values;
           foreach (var item in values)
           {
               Console.WriteLine(item); // vadi vs stoinosti v tozi rechnik
           }
           Console.WriteLine("____________________________________-");
           //__________________________________________________________

           var marks = new Dictionary<string, List<int>>(); // Речник в който да пазим оценките на студент  
                                                            // stringa е името, а в List ще пазим оценките му 
           marks["Ivan"] = new List<int>
           {
               1 , 2, 3  // String-a е името, а листта са оценките на всяка личност 
           };

           marks["Pesho"] = new List<int>
           {
               1 , 6, 6 // String-a е името, а листта са оценките на всяка личност 
           };

           marks["Ivan"].Add(4);// Добавям оценка на Иван в листта

           Console.WriteLine(string.Join(", ", marks["Pesho"])); // 1,6,6
           Console.WriteLine("____________________________________-");
           // Може да за по лесно да си ги вкарам в променливи за да е по нагледно WriteLine-a:

           var peshoMarks = marks["Pesho"];           // Същото е като горното !!
           var result = string.Join(", ", peshoMarks);// Същото е като горното !!
               Console.WriteLine(result);             // Същото е като горното !!
               Console.WriteLine("____________________________________-");
           // ____________________________________________________________

           //Добавяне и изчистване на речници:

               dictinary["Stefan"] = 20;
               Console.WriteLine(dictinary["Stefan"]);
               dictinary.Remove("Stefan"); // изтрива го
              // Console.WriteLine(dictinary["Stefan"]); // дава еррор изтрито е

               if (dictinary.ContainsKey("Stefan"))
               {
                   Console.WriteLine(dictinary["Stefan"]);
               }
               else // С такава ПРОВЕРКА мога да проверявам дали вече имам 
               { // вече такова име в речника;
                   Console.WriteLine("Iztrito e"); 
               }
               Console.WriteLine("____________________________________-");
           //______________________________________________________________________

           // KEY = 1вият тип в случая STRING
           // VALUE = 2рият тип в случая INT
           //____________________________________________________

               var rechnik = new Dictionary<string, int>();
               rechnik["Bagata"] = 6;
               Console.WriteLine(rechnik.ContainsKey("Bagata"));// Връща True, защото  е истина
               Console.WriteLine(rechnik.ContainsValue(6));     // Връща True, защото  е истина
               Console.WriteLine(rechnik.ContainsKey("Bagata"));// Връща True, защото  е истина
               Console.WriteLine(rechnik.ContainsValue(7));  // Връща False, защото  е Лъжа
               Console.WriteLine("____________________________________-");
           // Парсване на стрингове без да гърми

               int number = 0; // правя нова променлива
               string text = Console.ReadLine();// чета стринга от тук
               bool parsed = int.TryParse(text, out number); // При TryParse трябва да му дам кое да Parse-не в случая Text и ако успее къде да го запише чрез (text, out number) out e ключовата дума, а number e променливата, която съзададохме за тази цел. 
               Console.WriteLine(parsed);// ако дам Иван и дам ENTER -> ще изведе FALSE и отдоло за number  ще ми изведе 0;
               Console.WriteLine(number); //ако дам някаква стойност -> ще изведе TRUE и отдоло  за number ще ми изведе стойността, която съм въвел;
           //__________________________________________________
            // Същото нещо като отгоре с TryParse, само че в РЕЧНИК
              
           // ЩЕ ИЗПОЛЗВАМ РЕЧНИКА СИ DICTIONARY:

               int myNumber = 0;
               dictinary["Pesho"] = 6;
               bool valueExists = dictinary.TryGetValue("Pesho", out myNumber);

               Console.WriteLine(valueExists); // прави същото като горното 
               Console.WriteLine(number);
               Console.WriteLine("____________________________________-");

           // ПРАВЯ НОВ ФАЙЛ. С ПРОДЪЛЖЕНИЕ !!


















        }
    }
}
