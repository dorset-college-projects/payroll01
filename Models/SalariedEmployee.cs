using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll01.Models
{
    public class SalariedEmployee : Employee
    {
        private  decimal weeklySalary;
        public SalariedEmployee(string firstName, string lastName,
            string socialSecurityNumber, 
            decimal weeklySalary)
          : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(WeeklySalary)} must be > 0");
                } else
                {
                    weeklySalary = value;
                }

            }

        }


        public override decimal Earnings()
        {
            // throw new NotImplementedException();

            return WeeklySalary;
        }

        public override string ToString()
        {
            return $"Salaried Employee: {base.ToString()}\nEarnings: {Earnings()}";
        }
    }
}
