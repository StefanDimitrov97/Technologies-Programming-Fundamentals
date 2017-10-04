using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd_Occurrences
{
   public class Program
    {
       public static void Main()
        {
           // Odd_Occurrences - Да намеря нечетният брой повтарящи се думи в един речник!

            var words = Console.ReadLine()
               .ToLower()
                .Split(' ');
           // След това трябва да преброя всяка дума колко пъти се среща във думите:

           var wordCount = new Dictionary<string, int>(); // stringa = key;
                                                          // int = value;

            foreach (var word in words)// проверява всяка една написана дума от мен;
            { // ContainsKey защото искам да ми проверява само STRING-A, тоест stringa 
                if (!wordCount.ContainsKey(word)) // Ако речника за 1 път среща думата, да я запише в речника. 
                {
                    wordCount[word] = 0; // и ако не се среща да я добави в речника// 0 se dava prosto kato nqkakva stoinost
                }
                wordCount[word]++; // Да продължи напред към следващото място в речника 
            }                      // Отброява, че веднъж го е срещнал;
           // Когато го е срещнал само го изброява, че го е срещнал, защото ни трябва и бройка колко пъти чрез wordCount[word]++;
           var result = new List<string>();

            foreach (var item in wordCount) // за всеки елемент в речника, който съм срещнал
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }  
            }

           Console.WriteLine(string.Join(", ", result));

        }
    }
}
