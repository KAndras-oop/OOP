using System;

namespace _1_Employee
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Mihály",15000);
            Employee employee2 = new Employee("Nóra");

            Console.WriteLine(employee.DisplayInfo());
            Console.WriteLine(employee2.DisplayInfo());
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee2.ToString());
        }
    }
}
