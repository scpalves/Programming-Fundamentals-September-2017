using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstCharArray, secondCharArray;
        ReadingTwoCharArrays(out firstCharArray, out secondCharArray);

        if (secondCharArray.Length > firstCharArray.Length)
        {
            PrintingCharArray(firstCharArray, secondCharArray);
        }
        else if (secondCharArray.Length < firstCharArray.Length)
        {
            PrintingCharArray(secondCharArray, firstCharArray);
        }
        else
        {
            var longestArray = Math.Max(firstCharArray.Length, secondCharArray.Length);
            for (int i = 0; i < longestArray; i++)
            {
                if (firstCharArray[i] > secondCharArray[i])
                {
                    PrintingCharArray(secondCharArray, firstCharArray);
                    break;
                }
                else if (firstCharArray[i] < secondCharArray[i])
                {
                    PrintingCharArray(firstCharArray, secondCharArray);
                    break;
                }
                else
                {
                    PrintingCharArray(firstCharArray, secondCharArray);
                    break;
                }
            }
        }

    }

    private static void ReadingTwoCharArrays(out char[] firstCharArray, out char[] secondCharArray)
    {
        firstCharArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
        secondCharArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
    }

    static void PrintingCharArray(char[] firstCharArray, char[] secondCharArray)
    {
        Console.WriteLine(string.Join("",firstCharArray));
        Console.WriteLine(string.Join("",secondCharArray));
    }
}

