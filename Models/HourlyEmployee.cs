using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll01.Models
{
    public class HourlyEmployee : Employee
    {

        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber)
            :base(firstName, lastName, socialSecurityNumber)
        {

        }

        public override decimal Earnings() 
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Hourly Employee: {base.ToString()}";
        }
    }
}
