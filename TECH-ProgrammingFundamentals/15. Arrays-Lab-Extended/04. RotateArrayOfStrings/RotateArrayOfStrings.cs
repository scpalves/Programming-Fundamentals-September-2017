namespace _04.RotateArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string firstElement = words[words.Length - 1];
            for (int i = words.Length - 1; i > 0; i--)
            {
                words[i] = words[i - 1];
            }
            words[0] = firstElement;

            Console.WriteLine(string.Join(" ",words));
        }
    }
}
