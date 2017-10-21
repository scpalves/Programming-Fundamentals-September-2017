namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                var grades = inputTokens.Skip(1).Select(double.Parse).ToList();
                students.Add(new Student(name, grades));
            }

            var filteredStudents = students
                .Where(x => x.Grades.Average() >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Grades.Average())
                .ToList();

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.Grades.Average():f2}");
            }
        }
    }

    class Student
    {
        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        public string Name { get; set; }

        public List<double> Grades { get; set; }
    }
}
