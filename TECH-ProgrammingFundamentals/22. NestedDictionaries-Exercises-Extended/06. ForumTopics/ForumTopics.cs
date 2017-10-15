namespace _06.ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForumTopics
    {
        static Dictionary<string, HashSet<string>> topicData = 
            new Dictionary<string, HashSet<string>>();
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "filter")
            {
                var inputTokens = input
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = inputTokens[0];
                var tags = inputTokens[1]
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                AddToTopicData(topic, tags);
                input = Console.ReadLine();
            }

            var searchingForTags = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var data in topicData)
            {
                string topic = data.Key;
                var tags = data.Value;
                if (searchingForTags.All(x => tags.Contains(x)))
                {
                    var fixedTags = tags.Select(x => "#" + x).ToList();
                    Console.WriteLine($"{topic} | {string.Join(", ", fixedTags)}");
                }
            }
        }

        public static void AddToTopicData(string topic, string[] tags)
        {
            if (!topicData.ContainsKey(topic))
            {
                topicData.Add(topic, new HashSet<string>());
            }
            foreach (var tag in tags)
            {
                topicData[topic].Add(tag);
            }
            
        }
    }
}
