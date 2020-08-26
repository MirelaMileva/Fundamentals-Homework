using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }

                string[] tokens = input.Split("-");
                string userName = tokens[0];

                if (tokens.Length > 2)
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!students.ContainsKey(userName))
                    {
                        students.Add(userName, points);
                    }
                    else
                    {
                        if (students[userName] < points)
                        {
                            students[userName] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
                else
                {
                    if (students.ContainsKey(userName))
                    {
                        students.Remove(userName);
                    }
                }

            }

            Console.WriteLine("Results:");

            foreach (var student in students
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var submission in submissions
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
