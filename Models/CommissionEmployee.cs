using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll01.Models
{
    public class CommissionEmployee : Employee
    {
        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber)
       : base(firstName, lastName, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Commission Employee: {base.ToString()}";
        }
    }
}
