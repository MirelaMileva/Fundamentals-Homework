using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < pairs; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<double>());

                }

                studentGrades[studentName].Add(grade);

            }

            foreach (var student in studentGrades.OrderByDescending(s => s.Value.Average()))
            {
                var gradeSum = student.Value.Sum();
                var average = gradeSum / student.Value.Count;

                if (average < 4.50)
                {
                    studentGrades.Remove(student.Key);
                }
                else
                {
                    Console.WriteLine($"{student.Key} -> {average:f2}");
                }

            }
        }
    }
}
