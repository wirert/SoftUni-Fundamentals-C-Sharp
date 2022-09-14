using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "End")
            {
                string company = input[0];
                string employeeId = input[1];

                if (!companies.ContainsKey(company))
                    companies.Add(company, new List<string>());

                if (!companies[company].Contains(employeeId))
                    companies[company].Add(employeeId);

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
