using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll01.Models
{
    public class HourlyEmployee : Employee
    {

        private decimal wage;
        private decimal hours;



        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber,
            decimal hourlyWage, decimal hoursWorked)
            :base(firstName, lastName, socialSecurityNumber)
        {
            Wage = hourlyWage;
            Hours = hoursWorked;
        }

        public decimal Wage { get { return wage; } 
        
        set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Wage)} must be > 0");
                }
                else
                {
                    wage = value;
                }
            }
        }
        public decimal Hours { get { return hours; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Hours)} must be > 0");
                }
                else
                {
                    hours = value;
                }

            }
        }



        public override decimal Earnings() 
        {

            if (hours < 40)
            {
                return Wage * Hours;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
            }

        }

        public override string ToString()
        {
            return $"Hourly Employee: {base.ToString()}\nEarnings: {Earnings()}";
        }
    }
}
