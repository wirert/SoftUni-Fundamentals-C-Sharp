using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEmployee = int.Parse(Console.ReadLine());

            List<Department> departmentList = new List<Department>();

            for (int i = 0; i < numEmployee; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Employee employee = new Employee(input[0], double.Parse(input[1]), input[2]);
                Department department = new Department(input[2]);
                if (departmentList.Any(dep => dep.DepartmentName == input[2]))
                {
                    Department curDepartment = departmentList.Find(dep => dep.DepartmentName == input[2]);
                    curDepartment.EmployeesInDepartment.Add(employee);
                }
                else
                {
                    department.EmployeesInDepartment = new List<Employee>();
                    departmentList.Add(department);
                    department.EmployeesInDepartment.Add(employee);
                }
            }

            double bestAvSalary = Double.MinValue;
            Department bestDepartment = null;

            foreach (var department in departmentList)
            {
                double avSalary = 0;

                foreach (var employee in department.EmployeesInDepartment)
                {
                    avSalary += employee.Salary;
                }

                avSalary /= department.EmployeesInDepartment.Count;

                if (avSalary < bestAvSalary) continue;

                bestAvSalary = avSalary;
                bestDepartment = department;
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (var employee in bestDepartment.EmployeesInDepartment.OrderByDescending(employee => employee.Salary))
            {
                Console.WriteLine(employee);
            }
        }
    }

    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
    }

    class Department
    {
        public Department(string department)
        {
            this.DepartmentName = department;
        }

        public string DepartmentName { get; set; }
        public List<Employee> EmployeesInDepartment { get; set; }
    }
}
