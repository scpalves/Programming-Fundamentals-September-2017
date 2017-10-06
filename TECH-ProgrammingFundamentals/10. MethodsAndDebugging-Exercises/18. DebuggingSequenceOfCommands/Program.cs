using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] line = command.Split(ArgumentsDelimiter).ToArray();
            int[] args = new int[2];
            if (line[0].Equals("add") ||
                line[0].Equals("subtract") ||
                line[0].Equals("multiply"))
            {
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);

                PerformAction(array, line, args);
            }
            else if (line[0].Equals("rshift") ||
                     line[0].Equals("lshift"))
            {
                PerformAction(array, line, args);
            }
            PrintArray(array);
            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string[] action, int[] args)
    {
        //long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action[0])
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        var firstElement = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = firstElement;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        var lastElement = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = lastElement;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
