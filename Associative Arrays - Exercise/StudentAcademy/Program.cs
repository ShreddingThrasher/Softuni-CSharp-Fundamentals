using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> academy = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!academy.ContainsKey(student))
                {
                    academy.Add(student, new List<double>());
                }

                academy[student].Add(grade);
            }

            var filtered = academy.Where(x => x.Value.Average() >= 4.50);

            foreach (var student in filtered)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
