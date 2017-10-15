namespace _07.TakeSkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TakeSkipRope
    {
        static List<string> listOfNumbers = new List<string>();
        static List<char> listOfSymbols = new List<char>();
        static List<int> takeList = new List<int>();
        static List<int> skipList = new List<int>();
        public static void Main()
        {
            string encrypted = Console.ReadLine();
            IsDigit(encrypted);
            AddToSkipAndTakeLists();

            var decrypted = string.Empty;
            int total = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int skipIndexes = skipList[i];
                int takeIndexes = takeList[i];
                decrypted += new string(listOfSymbols.Skip(total).Take(takeIndexes).ToArray());
                total += skipIndexes + takeIndexes;
            }

            Console.WriteLine(decrypted);
        }

        public static void IsDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    listOfNumbers.Add(input[i].ToString());
                }
                else
                {
                    listOfSymbols.Add(input[i]);
                }
            }
        }

        public static void AddToSkipAndTakeLists()
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(int.Parse(listOfNumbers[i]));
                }
                else
                {
                    skipList.Add(int.Parse(listOfNumbers[i]));
                }
            }
        }
    }
}
