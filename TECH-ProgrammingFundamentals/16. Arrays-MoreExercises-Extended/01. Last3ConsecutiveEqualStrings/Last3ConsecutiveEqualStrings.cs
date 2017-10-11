using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_MoreExercises_Extended
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int counter = 1;
            var lastThreeEqualWords = new string[3];
            var saveLastEqualWord = words[words.Length - 1];

            for (int i = words.Length - 1; i > 0; i--)
            {
                string currentWord = words[i - 1];
                if (saveLastEqualWord == currentWord)
                {
                    counter++;
                    if (counter == 3)
                    {
                        break;
                    }
                }
                else
                {
                    saveLastEqualWord = words[i - 1];
                    counter = 1;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                lastThreeEqualWords[i] = saveLastEqualWord;
            }

            Console.WriteLine(string.Join(" ",lastThreeEqualWords));
        }
    }
}
