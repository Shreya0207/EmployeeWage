using EmployeeWageProgram;
using System;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage samsung = new EmpWage("Samsung", 10, 22, 120);
            EmpWage capg = new EmpWage("Capgemini", 25, 18, 80);
            samsung.compEmployeeWage();
            capg.compEmployeeWage();
            Console.WriteLine(samsung.toString());
            Console.WriteLine(capg.toString());
        }
    }
}
