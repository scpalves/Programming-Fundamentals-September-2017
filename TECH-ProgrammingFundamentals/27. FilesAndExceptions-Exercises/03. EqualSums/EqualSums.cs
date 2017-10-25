namespace _03.EqualSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class EqualSums
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../input.txt")
                .Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            File.Delete("../../output.txt");
            bool isFoundEqualSum = false;

            for (int i = 0; i < input.Length; i++)
            {
                var leftSum = input.Take(i).ToArray();
                var rightSum = input.Skip(i + 1).ToArray();
                if (leftSum.Sum() == rightSum.Sum())
                {
                    var output = i;
                    isFoundEqualSum = true;
                    File.AppendAllText("../../output.txt", output.ToString());
                    break;
                }
            }

            if (!isFoundEqualSum)
            {
                string nofound = "no";
                File.AppendAllText("../../output.txt", nofound);
            }
        }
    }
}
