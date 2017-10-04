using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd
{
    class Program
    {
        static void Main(string[] args)
        {
            int tp = int.Parse(Console.ReadLine()); //  The amount of pictures.
            int ft = int.Parse(Console.ReadLine()); // The filter time on seconds FOR EVERY SINGLE PICTURE!
            int ff = int.Parse(Console.ReadLine()); // The percentage of the total pictures that are considered “good” to be uploaded.
            int uploadTime = int.Parse(Console.ReadLine()); // The amount of time needed for every filtered picture to be uploaded to her storage.
             
            int filteredPictors = (tp - (tp * ff / 100));

            var secondsForFilter = tp * ft;
            var secondsForUpload = filteredPictors * uploadTime;
            var totalTime = secondsForFilter + secondsForUpload;

            var seconds = 0;
            var minutes = 0;
            var hours = 0;
            var days = 0;

        }
    }
}
