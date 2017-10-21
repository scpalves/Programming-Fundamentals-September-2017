using System.Runtime.CompilerServices;

namespace _08.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercises
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var exercises = new List<Exercise>();
            while (input != "go go go")
            {
                var inputTokens = input
                    .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string topic = inputTokens[0];
                string courseName = inputTokens[1];
                string judgeContestLink = inputTokens[2];
                var problems = inputTokens[3]
                    .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                exercises.Add(new Exercise(topic, courseName, judgeContestLink, problems));
                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                int counter = 1;
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }
            }
        }
    }

    class Exercise
    {
        public  Exercise (string topic, string courseName, string judgeContestLink, List<string> problems)
        {
            this.Topic = topic;
            this.CourseName = courseName;
            this.JudgeContestLink = judgeContestLink;
            this.Problems = problems;
        }
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }
}
