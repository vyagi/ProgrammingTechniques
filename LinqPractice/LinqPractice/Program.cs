using System;
using System.Linq;

namespace LinqPractice
{
    // class NameAndSalary
    // {
    //     public string FullName { get; set; }
    //     public decimal TotalSalary { get; set; }
    // }
    
    class Program
    {
        static void Main(string[] args)
        {
            //BasicLinqOperations();

            var employees = Employee.GetEmployees().ToList();
            
            //Select women employees
            var women = employees.Where(x=>x.Gender == Gender.Woman);

            //Select employees with seniority greater than 8 years
            var oldEmployee = employees.Where(x => x.Seniority > 8);

            var fullNames = employees.Select(x => $"{x.FirstName} {x.LastName}");

            var namesWithSalary = employees.Select(x => new 
            {
                FullName = $"{x.FirstName} {x.LastName}",
                TotalSalary = x.BaseSalary + x.Bonus
            });

            var fromOldestToYoungest = employees.OrderByDescending(x => x.Age);

            //3
            //var averageSalary = employees.Select(x => x.BaseSalary).Average();
            var averageSalary = employees.Average(x => x.BaseSalary);

            //4
            var aboveAverage = employees.Where(x => x.BaseSalary > averageSalary);

            //5 Select employees with bonus greater than 10 % of their salary
            var bigBonus = employees.Where(x => x.Bonus > 0.1M * x.BaseSalary);

            var byRoles = employees.GroupBy(x => x.Role).ToArray();

            // foreach (var roleGroup in byRoles)
            // {
            //     Console.WriteLine(roleGroup.Key);
            //     Console.WriteLine(roleGroup.Average(x=>x.Age));
            //     foreach (var employee in roleGroup)
            //     {
            //         Console.WriteLine($"   {employee.FirstName} {employee.LastName}");
            //     }
            // }

            //Alternative SQL - like syntax"

            var women1 = 
                from employee in employees
                where employee.Gender == Gender.Woman
                select employee;

            var fromOldestToYoungest1 =
                from employee in employees
                orderby employee.Age descending
                select employee;

            var namesWithSalary1 =
                from employee in employees
                select new
                {
                    FullName = $"{employee.FirstName} {employee.LastName}",
                    TotalSalary = employee.BaseSalary + employee.Bonus
                };


        }

        private static void BasicLinqOperations()
        {
            var ages = new[] {42, 12, 32, 45};

            Console.WriteLine(ages.Min());
            Console.WriteLine(ages.Max());
            Console.WriteLine(ages.Sum());
            Console.WriteLine(ages.Average());
        }
    }
}
