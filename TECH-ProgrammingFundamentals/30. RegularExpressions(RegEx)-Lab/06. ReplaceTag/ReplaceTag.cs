using System.Text.RegularExpressions;

namespace _06.ReplaceTag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReplaceTag
    {
        public static void Main()
        {
            string tag = Console.ReadLine();
            string pattern = @"<a.*?href=("".*?"")>(.*?)<\/a>";

            while (tag != "end")
            {
               var replace =  Regex.Replace(tag, pattern, "[URL href=$1]$2[/URL]");
                Console.WriteLine(replace);
                tag = Console.ReadLine();
            }
        }
    }
}
