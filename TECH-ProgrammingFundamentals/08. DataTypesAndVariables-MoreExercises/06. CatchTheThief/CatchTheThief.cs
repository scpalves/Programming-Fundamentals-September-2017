using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CatchTheThief
{
    static void Main()
    {
        string numeralType = Console.ReadLine();
        long counterOfIds = long.Parse(Console.ReadLine());
        long currentId = 0;
        long idSave = long.MinValue;

        for (int i = 0; i < counterOfIds; i++)
        {
            currentId = long.Parse(Console.ReadLine());

            if (numeralType == "sbyte")
            {
                if (sbyte.MinValue <= currentId && currentId <= sbyte.MaxValue)
                {
                    if (currentId > idSave)
                    {
                        idSave = currentId;
                    }
                }
            }
            else if (numeralType == "int")
            {
                if (int.MinValue <= currentId && currentId <= int.MaxValue)
                {
                    if (currentId > idSave)
                    {
                        idSave = currentId;
                    }
                }
            }
            else if (numeralType == "long")
            {
                if (long.MinValue <= currentId && currentId <= long.MaxValue)
                {
                    if (currentId > idSave)
                    {
                        idSave = currentId;
                    }
                }
            }
        }

        Console.WriteLine(idSave);
    }
}

