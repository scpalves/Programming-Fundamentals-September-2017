namespace StringAndTextProcessing_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseStrings
    {
        public static void Main()
        {
            string text = new string(Console.ReadLine()
                .Reverse()
                .ToArray());

            Console.WriteLine(string.Join("",text));
        }
    }
}
