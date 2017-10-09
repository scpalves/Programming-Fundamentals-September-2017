using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ManipulateArray
{
    static string[] input =
        Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    static void Main()
    {
        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var command =
                Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (command[0] == "Distinct")
            {
                DistinctArray();
            }
            else if (command[0] == "Reverse")
            {
                ReverseArray();
            }
            else if (command[0] == "Replace")
            {
                var index = int.Parse(command[1]);
                var newWord = command[2];
                ReplaceInArray(index, newWord);
            }
        }

        Console.WriteLine(string.Join(", ",input));
    }

    static void DistinctArray()
    {
        input = input.Distinct().ToArray();
    }

    static void ReverseArray()
    {
        Array.Reverse(input);
    }

    static void ReplaceInArray(int index, string newWord)
    {
        input[index] = newWord;
    }
}

