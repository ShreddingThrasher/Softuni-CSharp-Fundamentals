using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "End")
                {
                    break;
                }

                Person p = new Person(input[0], input[1], int.Parse(input[2]));
                people.Add(p);
            }

            foreach (Person p in people.OrderBy(p => p.Age))
            {
                Console.WriteLine(p);
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
