using System.Runtime.Remoting.Messaging;

namespace _05.ParkingValidation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingValidation
    {
        public static Dictionary<string, string> parkingData =
            new Dictionary<string, string>();

        public static bool isPlateNumberExist = false;
        public static bool isUserExist = false;

        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string regOrUnreg = inputTokens[0];
                string user = inputTokens[1];
                if (isUserExist)
                {
                    Console.WriteLine($"ERROR: already registered with plate number {parkingData[user]}");
                }
                else
                {
                    if (regOrUnreg == "register")
                    {
                        string plateNumber = inputTokens[2];
                        if (IsLicenseValid(plateNumber))
                        {
                            AddToParkingData(user, plateNumber);
                            if (isPlateNumberExist)
                            {
                                Console.WriteLine($"ERROR: license plate {plateNumber} is busy");
                            }
                            else
                            {
                                Console.WriteLine($"{user} registered {plateNumber} successfully");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: invalid license plate {plateNumber}");
                        }
                    }
                    else
                    {
                        RemoveFromParkingData(user);
                    }
                }
               
            }
            PrintParkingData();
        }

        public static bool IsLicenseValid(string license)
        {
            //Spliting plate number And use 2 methods for cheking is valid or no.
            string leftSide = license.Substring(0, 2);
            string midSide = license.Substring(2, 4);
            string rightSide = license.Substring(6, 2);
            if (IsLetterInUpperCase(leftSide) && IsDigit(midSide) && IsLetterInUpperCase(rightSide))
            {
                return true;
            }
            return false;

        }

        public static bool IsDigit(string word)
        {
            //Checking if we got 4 numbers in plate license on middle side.
            if (word.All(d => d >= '0' && d <= '9'))
            {
                return true;
            }
            return false;
        }

        public static bool IsLetterInUpperCase(string leftSide)
        {
            //Checking if we got 2 letters left and right ON SIDE AND ARE THEY UPPER CASE
            if (leftSide.All(l => l >= 'A' && l <= 'Z'))
            {
                return true;
            }
            return false;
        }

        public static void AddToParkingData(string user, string plateNumber)
        {
            //Do we have user which already exist.
            if (parkingData.ContainsKey(user))
            {
                isUserExist = true;
            }
            // Or plate number maybe
            else if (!parkingData.ContainsKey(user) && parkingData.ContainsValue(plateNumber))
            {
                isPlateNumberExist = true;
            }
            // both of them missing
            else
            {
                isUserExist = false;
                isPlateNumberExist = false;
                parkingData.Add(user, plateNumber);
            }
        }

        public static void RemoveFromParkingData(string user)
        {
            // Is UnRegistrastion successful and remove user from ParkingData.
            if (parkingData.ContainsKey(user))
            {
                Console.WriteLine($"user {user} unregistered successfully");
                parkingData.Remove(user);
            }
            // If user dont exist at all.
            else
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
        }

        //Printing finally data from ParkingData.
        public static void PrintParkingData()
        {
            foreach (var users in parkingData)
            {
                string user = users.Key;
                string plateNumber = users.Value;
                Console.WriteLine($"{user} => {plateNumber}");
            }
        }
    }
}
