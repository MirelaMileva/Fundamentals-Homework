using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" -> ");
                string company = tokens[0];
                string employeeId = tokens[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees.Add(company, new List<string>()); 
                }

                if (companyEmployees[company].Contains(employeeId))
                {
                    continue;
                }
                else
                {
                    companyEmployees[company].Add(employeeId);
                }
                

            }

            foreach (var company in companyEmployees.OrderBy(e => e.Key))
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
