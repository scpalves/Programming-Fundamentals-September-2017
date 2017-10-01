using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BoatSimulator
{
    static void Main()
    {
        char firstBoatName = char.Parse(Console.ReadLine());
        char secondBoatName = char.Parse(Console.ReadLine());
        int numberOfStrings = int.Parse(Console.ReadLine());

        int firstBoatMoves = 0;
        int secondBoatMoves = 0;
        int newName = 0;

        for (int i = 0; i < numberOfStrings; i++)
        {
            string currentString = Console.ReadLine();

            if (currentString == "UPGRADE")
            {
                newName = firstBoatName + 3;
                firstBoatName = (char)newName;

                newName = 0;

                newName = secondBoatName + 3;
                secondBoatName = (char)newName;
            }
            else
            {
                if (i % 2 != 0)
                {
                    secondBoatMoves += currentString.Length;
                }
                else
                {
                    firstBoatMoves += currentString.Length;
                }
            }
            if (firstBoatMoves >= 50)
            {
                Console.WriteLine(firstBoatName);
                return;
            }
            else if (secondBoatMoves >= 50)
            {
                Console.WriteLine(secondBoatName);
                return;
            }
        }

        if (firstBoatMoves > secondBoatMoves)
        {
            Console.WriteLine(firstBoatName);
        }
        else
        {
            Console.WriteLine(secondBoatName);
        }
    }
}

