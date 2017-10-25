namespace _02.IndexOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string str = File.ReadAllText("../../input.txt");
            File.Delete("../../output.txt");
            var output = str.Select(c => c + " -> " + (c - 'a')).ToArray();
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
