using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll01.Models
{
    public class BasePlusCommissionEmployee : Employee
    {

        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber)
        : base(firstName, lastName, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"BasePlusCommission Employee: {base.ToString()}";
        }
    }
}
