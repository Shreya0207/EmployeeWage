using System;

namespace EmployeeWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageArrayMethod wageCalculation = new EmpWageArrayMethod();
            wageCalculation.addCompanyEmpWage("SAMSUNG", 25, 18, 80);
            wageCalculation.addCompanyEmpWage("CAPGEMINI", 50, 28, 120);
            wageCalculation.compEmployeeWage();
        }
    }
}
