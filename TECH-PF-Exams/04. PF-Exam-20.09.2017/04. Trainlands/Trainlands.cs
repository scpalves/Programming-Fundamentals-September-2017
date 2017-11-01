namespace _04.Trainlands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainlands
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var trainData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "It's Training Men!")
            {
                var inputTokens = input
                    .Split(new string[] { " -> ", " : ", " = " }, StringSplitOptions.RemoveEmptyEntries);

                string trainName = inputTokens[0];

                if (inputTokens.Length == 3)
                {
                    string wagonName = inputTokens[1];
                    int power = int.Parse(inputTokens[2]);
                    AddToTrainData(trainData, trainName, wagonName, power);
                }
                else if (inputTokens.Length == 2 && input.Contains(" -> "))
                {
                    string otherTrainName = inputTokens[1];
                    AddWagonsFromOtherTrain(trainData, trainName, otherTrainName);
                }
                else if (inputTokens.Length == 2 && input.Contains(" = "))
                {
                    string otherTrainName = inputTokens[1];
                    CopiesOtherTrainWagons(trainData, trainName, otherTrainName);
                }

                input = Console.ReadLine();
            }
            PrintTrainData(trainData);
        }

        public static void PrintTrainData(Dictionary<string, Dictionary<string, int>> trainData)
        {
            foreach (var trains in trainData
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Value.Values.Count))
            {
                string trainName = trains.Key;
                var trainsValues = trains.Value;
                Console.WriteLine($"Train: {trainName}");

                foreach (var wagonsAndPower in trainsValues
                    .OrderByDescending(x => x.Value))
                {
                    string wagon = wagonsAndPower.Key;
                    int power = wagonsAndPower.Value;
                    Console.WriteLine($"###{wagon} - {power}");
                }
            }
        } 

        public static void CopiesOtherTrainWagons(Dictionary<string, Dictionary<string, int>> trainData,
            string trainName, string otherTrainName)
        {
            if (!trainData.ContainsKey(trainName))
            {
                trainData.Add(trainName, new Dictionary<string, int>());
            }

            var newWagons = trainData[otherTrainName];
            trainData[trainName].Clear();

            foreach (var wagons in newWagons)
            {
                trainData[trainName].Add(wagons.Key, wagons.Value);
            }
        }

        public static void AddWagonsFromOtherTrain(Dictionary<string, Dictionary<string, int>> trainData,
            string trainName, string otherTrainName)
        {
            if (!trainData.ContainsKey(trainName))
            {
                trainData.Add(trainName, new Dictionary<string, int>());
            }

            var otherTrainWagons = trainData[otherTrainName];
            trainData.Remove(otherTrainName);

            foreach (var wagonsAndPower in otherTrainWagons)
            {
                trainData[trainName].Add(wagonsAndPower.Key, wagonsAndPower.Value);
            }
        }

        public static void AddToTrainData(Dictionary<string, Dictionary<string, int>> trainData,
            string trainName, string wagonName, int wagonPower)
        {
            if (!trainData.ContainsKey(trainName))
            {
                trainData.Add(trainName, new Dictionary<string, int>());
            }
            trainData[trainName].Add(wagonName, wagonPower);
        }
    }
}
