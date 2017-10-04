using System;
using System.Linq;

namespace proba_izpit_1_zadacha
{
    class Program
    {
        static void Main()
        {
            double toralPictores = int.Parse(Console.ReadLine()); //  The amount of pictures.
            double filterTime = int.Parse(Console.ReadLine()); // The filter time on seconds FOR EVERY SINGLE PICTURE!
            double filterFactor = int.Parse(Console.ReadLine()); // The percentage of the total pictures that are considered “good” to be uploaded.
            double uploadTime = int.Parse(Console.ReadLine()); // The amount of time needed for every filtered picture to be uploaded to her storage.
            
            double filteredPictors = Math.((toralPictores - (toralPictores * (filterFactor / 100))));
            double filteredPictors222 = filteredPictors - (filteredPictors * (filterFactor / 100));
            double endOfFilterTime = toralPictores * filterTime;
            double endOfUploadTime = filteredPictors * uploadTime;
            double totalTime = endOfUploadTime + endOfFilterTime;

            var TimeInSec = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine(TimeInSec.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
