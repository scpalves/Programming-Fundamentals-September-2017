using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BalancedBrackets
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        int openBracketCounter = 0;
        int closeBracketCounter = 0;

        for (int i = 0; i < numberOfLines; i++)
        {
            string currentInputLine = Console.ReadLine();

            if (currentInputLine == "(")
            {
                openBracketCounter++;
                if (openBracketCounter - closeBracketCounter > 1)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            else if (currentInputLine == ")")
            {
                closeBracketCounter++;
                if (openBracketCounter - closeBracketCounter != 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;

                }
            }
        }

        if (openBracketCounter == closeBracketCounter)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}

