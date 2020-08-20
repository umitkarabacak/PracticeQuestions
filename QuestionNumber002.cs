using System;
using System.Collections.Generic

namespace Questions.Number002
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FullName => $"{Id} -> {Name}";
    }

    public class EmployeeManager001
    {
        public List<Employee> GetEmployeesMethodOne()
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                employees.Add(new Employee
                {
                    Id = i,
                    Name = $"Example User Name{i}"
                });
            }
        }
    }

    public class EmployeeManager002
    {
        public List<Employee> GetEmployeesMethodTwo()
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                Employee employee = new Employee();
                employee.Id = i;
                employee.Name = $"Example User Name{i}";

                employees.Add(employee);
            }
        }
    }
    public class EmployeeManager003
    {
        public List<Employee> GetEmployeesMethodThree()
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                Employee employee = new Employee()
                {
                    Id = i,
                    Name = $"Example User Name{i}"
                };

                employees.Add(employee);
            }
        }
    }

    public class Program
    {
        void Main(string[] args)
        {
            var usageOne = new EmployeeManager001().GetEmployeesMethodOne();
            var usageTwo = new EmployeeManager002().GetEmployeesMethodTwo();
            var usageThree = new EmployeeManager003().GetEmployeesMethodThree();
        }
    }
}