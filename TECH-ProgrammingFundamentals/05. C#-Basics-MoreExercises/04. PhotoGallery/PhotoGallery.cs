using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PhotoGallery
{
    static void Main()
    {
        var photoNumber = int.Parse(Console.ReadLine());
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var size = double.Parse(Console.ReadLine());
        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());

        Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");

        if (size <= 999)
        {
            Console.WriteLine($"Size: {size}B");
        }
        else if (size <= 999999)
        {
            var sizeInKBytes = size / 1000;
            Console.WriteLine($"Size: {sizeInKBytes}KB");
        }
        else
        {
            var sizeInMBytes = size / 1000000;
            Console.WriteLine($"Size: {sizeInMBytes}MB");
        }
        if (width == height)
        {
            Console.WriteLine($"Resolution: {width}x{height} (square)");
        }
        else if (width > height)
        {
            Console.WriteLine($"Resolution: {width}x{height} (landscape)");
        }
        else
        {
            Console.WriteLine($"Resolution: {width}x{height} (portrait)");
        }
    }
}

