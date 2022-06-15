using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Library
{
    //Marking a class as sealed terminates the inheritance chain.
    //This means that this class cannot be inherited from.
    public sealed class HourlyEmployee : Employee
    {
        //FIELDS
        //None

        //PROPERTIES
        public decimal HoursWorked { get; set; }

        public decimal HourlyWage { get; set; }

        //CONSTRUCTORS
        public HourlyEmployee(int id, string firstName, string lastName, DateTime dateOfBirth, 
            string title, DateTime hireDate, bool isDirectDeposit, decimal hoursWorked, decimal hourlyWage) 
            : base(id, firstName, lastName, dateOfBirth, title, hireDate, isDirectDeposit)
        {
            HoursWorked = hoursWorked;
            HourlyWage = hourlyWage;
        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            return string.Format($"{base.ToString()}\nHours Worked: {HoursWorked}\n" +
                $"Hourly Wage: {HourlyWage:c}");
        }

        //The GetNameForPaycheck() was satisfied by the Employee class and passed here via
        //inheritance. BUT, Employee could NOT fulfill the GetPaycheckAmount() so we will
        //need to implement it here.

        public override decimal GetPaycheckAmount()
        {
            //Pay the employee
            //HoursWorked * HourlyWage - Common thought process for hourly workers.
            //Pay period? What about overtime pay?
            //In the real world, we need to know ALL of the payment requirements for 
            //an hourly employee. REQUIREMENTS GATHERING is EXTREMELY important so 
            //we can define overtime, thresholds, hazard pay, and any other considerations.
            //If you work in an enterprise environment and were tasked with making a payroll
            //application like this one, you would need to return these questions to 
            //your project manager, business analyst, or supervisor.

            //In this example, our hourly employees are paid regular pay for the first 40 hours
            //and time & a half for anything over 40. They are also paid weekly.

            //Local variable to represent the paycheck
            decimal paycheck;

            //Regular Work Time (<=40 hours)
            if (HoursWorked <= 40)
            {
                paycheck = HoursWorked * HourlyWage;
            }
            else //OT has been earned
            {
                //Obtain the OT hours
                decimal overtime = HoursWorked - 40;

                //Calculate the paycheck
                paycheck = (40 * HourlyWage) + (overtime * HourlyWage * 1.5m);
            }

            //No matter what, return the correct value for paycheck
            return paycheck;
        }

    }//end class
}//end namespace
