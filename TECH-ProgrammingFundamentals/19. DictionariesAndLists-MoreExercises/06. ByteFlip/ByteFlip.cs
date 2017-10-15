namespace _06.ByteFlip
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ByteFlip
    {
        public static void Main()
        {
            var bytesArray = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length == 2)
                .ToArray();
            var finalMessage = new List<char>();

            for (int i = 0; i < bytesArray.Length; i++)
            {
                var currentNumber = bytesArray[i];
                var reverseHexadecimalNumber = currentNumber.Reverse().ToArray();
                bytesArray[i] = new string(reverseHexadecimalNumber);
            }

            for (int i = 0; i < bytesArray.Length; i++)
            {
                int value = Convert.ToInt32(bytesArray[i], 16);
                finalMessage.Add((char)value);
            }

            finalMessage.Reverse();
            Console.WriteLine(string.Join("",finalMessage));
        }
    }
}
