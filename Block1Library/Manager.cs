using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Library
{
    public sealed class Manager : SalariedEmployee
    {
        //FIELDS
        //none

        //PROPERTIES
        public decimal YearlyBonus { get; set; }

        //CONSTRUCTORS
        public Manager(int id, string firstName, string lastName, DateTime dateOfBirth,
            string title, DateTime hireDate, bool isDirectDeposit, decimal yearlySalary, 
            decimal bonus) : base(id, firstName, lastName, dateOfBirth, title, hireDate, 
                isDirectDeposit, yearlySalary)
        {
            YearlyBonus = bonus;
        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            return string.Format($"{base.ToString()}\nBonus: {YearlyBonus:c}");
        }

        //By default the manager class inherits the functionality of GetPaycheckAmount()
        //from the SalariedEmployee class. However, the Manager should ALSO get a Bonus
        //in addition to the salary value. The ONLY way to ensure the Manager is paid
        //the appropriate amount is to override the functionality of the inherited Method.

        public override decimal GetPaycheckAmount()
        {
            //Bonuses can be distributed in multiple ways. Once again, you will need 
            //to get this specific information via REQUIREMENTS GATHERING.

            //Manager is paid monthly and the bonus is distributed evenly throughout the year.

            //Since we are using inheritance from SalariedEmployee, the property YearlySalary is already created from the parent class we are inheriting from.

            return (YearlySalary / 12) + (YearlyBonus / 12);
        }

    }
}
