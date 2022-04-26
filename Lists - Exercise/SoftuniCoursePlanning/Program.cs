using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string input;

            while((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(':');

                switch (command[0])
                {
                    case "Add":
                        if(!LessonExist(schedule, command[1]))
                        {
                            schedule.Add(command[1]);
                        }

                        break;
                    case "Insert":
                        
                        if(!LessonExist(schedule, command[1]))
                        {
                            int index = int.Parse(command[2]);
                            schedule.Insert(index, command[1]);
                        }

                        break;
                    case "Remove":

                        if(LessonExist(schedule, command[1]))
                        {
                            schedule.Remove(command[1]);
                            schedule.Remove($"{command[1]}-Exercise");
                        }

                        break;
                    case "Swap":

                        if(LessonExist(schedule, command[1]) && LessonExist(schedule, command[2]))
                        {
                            string temp = schedule.Find(x => x == command[1]);

                            int firstIndex = schedule.IndexOf(command[1]);
                            int secondIndex = schedule.IndexOf(command[2]);

                            schedule[firstIndex] = command[2];
                            schedule[secondIndex] = temp;

                            if (schedule.Contains($"{command[1]}-Exercise"))
                            {
                                schedule.Remove($"{command[1]}-Exercise");
                                schedule.Insert(secondIndex + 1, $"{command[1]}-Exercise");
                            }

                            if (schedule.Contains($"{command[2]}-Exercise"))
                            {
                                schedule.Remove($"{command[2]}-Exercise");
                                schedule.Insert(firstIndex + 1, $"{command[2]}-Exercise");
                            }
                        }

                        break;

                    case "Exercise":

                        if(LessonExist(schedule, command[1]))
                        {
                            int index = schedule.IndexOf(command[1]);
                            schedule.Insert(index + 1, $"{command[1]}-Exercise");
                        }
                        else
                        {
                            schedule.Add(command[1]);
                            schedule.Add($"{command[1]}-Exercise");
                        }

                        break;
                }

            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        static bool LessonExist(List<string> schedule, string lesson)
        {
            return schedule.Any(x => x == lesson);
        }
    }
}
