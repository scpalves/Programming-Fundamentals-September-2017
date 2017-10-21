using System.Globalization;

namespace ObjectsAndClasses_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DayOfWeek
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
