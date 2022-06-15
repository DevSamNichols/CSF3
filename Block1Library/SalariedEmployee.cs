using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Library
{
    public class SalariedEmployee : Employee
    {
        //FIELDS
        //None

        //PROPERTIES
        public decimal YearlySalary { get; set; }

        //CONSTRUCTORS
        public SalariedEmployee(int id, string firstName, string lastName, DateTime dateOfBirth,
            string title, DateTime hireDate, bool isDirectDeposit, decimal yearlySalary) 
            : base(id, firstName, lastName, dateOfBirth, title, hireDate, isDirectDeposit)
        {
            YearlySalary = yearlySalary;
        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            return string.Format($"{base.ToString()}\nYearly Salary: {YearlySalary:c}");
        }

        //Implemented and fulfilled the GetNameForPaycheck() in the parent class & inherited it.
        //We have NOT yet fulfilled the GetPayCheckAmount().

        public override decimal GetPaycheckAmount()
        {
            //Pay period/frequency
            //Weekly pay would mean 52 pay periods.
            //Biweekly pay would mean 26 pay periods.
            //Bimonthly/Semimonthly pay would mean 24 pay periods.
            //Monthly pay would mean 12 pay periods.
            //REQUIREMENTS GATHERING is extremely important.
            //If you are given a pay period description, you should
            //still ask for the number of pay periods per year.

            //For this example, our company is biweekly
            return YearlySalary / 26;
        }

    }//end class
}//end namespace
