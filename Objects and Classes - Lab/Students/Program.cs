using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] studentData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string homeTown = studentData[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                students.Add(student);
            }

            string city = Console.ReadLine();

            PrintStudentsByCity(students, city);
        }
        static void PrintStudentsByCity(List<Student> students, string city)
        {
            foreach (Student student in students.Where(s => s.HomeTown == city))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
