using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

            string input;

            while((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" -> ");

                string company = command[0];
                string employeeId = command[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new HashSet<string>());
                }

                companies[company].Add(employeeId);
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                foreach (var employee in companies[company.Key])
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
