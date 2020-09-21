
using Payroll01.Models;
using System;

namespace Payroll01
{
    class Program
    {
        static void Main(string[] args)
        {

          
            SalariedEmployee salariedEmployee = new SalariedEmployee("Peter", "Parker", "SPIDER001", 10.0M);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Bruce","Wayne","BAT001");
            CommissionEmployee commissionEmployee = new CommissionEmployee("David", "Banner", "HULK001");
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Clark", "Kent", "SUPER001");


          
            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(salariedEmployee.ToString());
            Console.WriteLine(commissionEmployee.ToString());
            Console.WriteLine(basePlusCommissionEmployee.ToString());
            
        }
    }
}
