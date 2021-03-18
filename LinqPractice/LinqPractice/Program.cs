using System;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicLinqOperations();

            var employees = Employee.GetEmployees();
            //Select women employees
            var women = employees.Where(x=>x.Gender == Gender.Woman);

            //Select employees with seniority greater than 8 years

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
