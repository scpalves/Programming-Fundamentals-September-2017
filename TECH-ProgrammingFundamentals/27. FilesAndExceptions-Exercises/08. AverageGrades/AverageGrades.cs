namespace _08.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class AverageGrades
    {
        public static void Main()
        {
            var input = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            int numberOfStudents = int.Parse(input[0]);
            var students = new List<Student>();

            for (int i = 1; i <= numberOfStudents; i++)
            {
                var inputTokens = input[i].Split();
                string name = inputTokens[0];
                var grades = inputTokens.Skip(1).Select(double.Parse).ToList();

                var student = new Student()
                {
                    Name = name,
                    Grades = grades
                };
                students.Add(student);
            }

            foreach (var student in students
                .Where(x => x.Grades.Average() >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Grades))
            {
                string output = $"{student.Name} -> {student.Grades.Average():f2} {Environment.NewLine}";
                File.AppendAllText("../../output.txt", output);
            }
        }
    }

    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }
    }
}
