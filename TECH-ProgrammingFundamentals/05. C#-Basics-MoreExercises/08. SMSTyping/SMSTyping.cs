using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SMSTyping
{
    static void Main()
    {
        int numberOfNumbers = int.Parse(Console.ReadLine());
        var textMessage = string.Empty;

        for (int number = 0; number < numberOfNumbers; number++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            switch (currentNumber)
            {
                case 0:
                    textMessage += " ";
                    break;
                case 2:
                    textMessage += "a";
                    break;
                case 22:
                    textMessage += "b";
                    break;
                case 222:
                    textMessage += "c";
                    break;
                case 3:
                    textMessage += "d";
                    break;
                case 33:
                    textMessage += "e";
                    break;
                case 333:
                    textMessage += "f";
                    break;
                case 4:
                    textMessage += "g";
                    break;
                case 44:
                    textMessage += "h";
                    break;
                case 444:
                    textMessage += "i";
                    break;
                case 5:
                    textMessage += "j";
                    break;
                case 55:
                    textMessage += "k";
                    break;
                case 555:
                    textMessage += "l";
                    break;
                case 6:
                    textMessage += "m";
                    break;
                case 66:
                    textMessage += "n";
                    break;
                case 666:
                    textMessage += "o";
                    break;
                case 7:
                    textMessage += "p";
                    break;
                case 77:
                    textMessage += "q";
                    break;
                case 777:
                    textMessage += "r";
                    break;
                case 7777:
                    textMessage += "s";
                    break;
                case 8:
                    textMessage += "t";
                    break;
                case 88:
                    textMessage += "u";
                    break;
                case 888:
                    textMessage += "v";
                    break;
                case 9:
                    textMessage += "w";
                    break;
                case 99:
                    textMessage += "x";
                    break;
                case 999:
                    textMessage += "y";
                    break;
                case 9999:
                    textMessage += "z";
                    break;
            }
        }

        Console.WriteLine(textMessage);
    }
}

