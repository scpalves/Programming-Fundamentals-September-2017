namespace _03.WormHole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WormHole
    {
        public static void Main()
        {
            var wormHoles = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int stepsCounter = 0;

            for (int i = 0; i < wormHoles.Length; i++)
            {
                if (wormHoles[i] == 0)
                {
                    stepsCounter++;
                }
                else
                {
                    int goBackTo = wormHoles[i];
                    wormHoles[i] = 0;
                    i = goBackTo;
                    stepsCounter++;
                }
            }

            Console.WriteLine(stepsCounter);
        }
    }
}
