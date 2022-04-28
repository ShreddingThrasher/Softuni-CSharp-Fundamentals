using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string user = command[1];

                switch (command[0])
                {
                    case "register":

                        if (parking.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                            continue;
                        }

                        string licensePlateNumber = command[2];

                        parking.Add(user, licensePlateNumber);
                        Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
                        break;
                    case "unregister":

                        if (!parking.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                            continue;
                        }

                        parking.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                        break;
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
