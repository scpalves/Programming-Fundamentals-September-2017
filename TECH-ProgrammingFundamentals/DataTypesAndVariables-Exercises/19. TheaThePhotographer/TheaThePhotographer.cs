using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheaThePhotographer
{
    static void Main()
    {

        int numberOfPictures = int.Parse(Console.ReadLine());
        int filterTime = int.Parse(Console.ReadLine());
        int filterFactor = int.Parse(Console.ReadLine());
        int uploadTime = int.Parse(Console.ReadLine());

        double filteredPictures = (Math.Ceiling(numberOfPictures * filterFactor / 100.0));
        double totalFilterTime = (double)numberOfPictures * filterTime;
        double timeForUpload = filteredPictures * uploadTime;
        double totalTime = totalFilterTime + timeForUpload;

        TimeSpan duration = TimeSpan.FromSeconds(totalTime);
        string timeInStringFormat = duration.ToString(@"d\:hh\:mm\:ss");

        Console.WriteLine(timeInStringFormat);

    }
}

