using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SafeManipulation
{
    private static string[] input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    static void Main()
    {
        var commands = Console.ReadLine();

        while (commands != "END")
        {
            var items = commands
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string currentCommand = items[0];

            switch (currentCommand)
            {
                case "Distinct":
                    DistinctArray();
                    break;
                case "Reverse":
                    ReverseArray();
                    break;
                case "Replace":
                    var index = int.Parse(items[1]);

                    if (index > input.Length - 1 || index < 0)
                    {
                        PrintInvalidInput();
                    }
                    else
                    {
                        string newWord = items[2];
                        ReplaceInArray(index, newWord);
                    }
                    break;
                default:
                    PrintInvalidInput();
                    break;
            }
            commands = Console.ReadLine();
        }
        Console.WriteLine(string.Join(", ", input));
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

    static void PrintInvalidInput()
    {
        Console.WriteLine("Invalid input!");
    }
}

