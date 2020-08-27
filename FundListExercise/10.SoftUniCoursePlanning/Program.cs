using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] commands = input.Split(":");
                string lesson = commands[1];

                if (commands[0] == "Add")
                {
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Insert(index, lesson);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    string checkForExercise = commands[1] + "-" + "Exercise";
                    if (schedule.Contains(lesson))
                    {
                        schedule.Remove(lesson);
                    }
                    if (schedule.Contains(checkForExercise))
                    {
                        schedule.Remove(checkForExercise);
                    }
                }
                else if (commands[0] == "Swap")
                {
                    string secondLessonTitle = commands[2];
                    if (schedule.Contains(lesson) && schedule.Contains(secondLessonTitle))
                    {
                        int firstLessonIndex = schedule.IndexOf(lesson);
                        int secondLessonIndex = schedule.IndexOf(secondLessonTitle);
                        schedule[firstLessonIndex] = secondLessonTitle;
                        schedule[secondLessonIndex] = lesson;

                        string checkForExercise = lesson + "-" + "Exercise";
                        string checkForExerciseSecond = secondLessonTitle + "-" + "Exercise";

                        if (schedule.Contains(checkForExercise))
                        {
                            firstLessonIndex = schedule.IndexOf(lesson);
                            schedule.Remove(checkForExercise);
                            schedule.Insert(firstLessonIndex + 1, checkForExercise);
                        }
                        if (schedule.Contains(checkForExerciseSecond))
                        {
                            secondLessonIndex = schedule.IndexOf(secondLessonTitle);
                            schedule.Remove(checkForExerciseSecond);
                            schedule.Insert(secondLessonIndex + 1, checkForExerciseSecond);
                        }

                    }

                }
                else if (commands[0] == "Exercise")
                {
                    string addExercise = lesson + "-" + "Exercise";
                    if (schedule.Contains(lesson))
                    {
                        int lessonIndex = schedule.IndexOf(lesson);
                        if (!schedule.Contains(addExercise))
                        {
                            schedule.Insert(lessonIndex + 1, addExercise);
                        }
                    }

                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                        schedule.Add(addExercise);
                    }
                }

                input = Console.ReadLine();
            }

            int count = 0;
            for (int i = 0; i < schedule.Count; i++)
            {
                count += 1;
                Console.WriteLine($"{count}.{schedule[i]}");
            }
        }
    }
}
