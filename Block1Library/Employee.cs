using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ABCPayroll;

namespace Block1Library
{
    //Only the FIRST class of a Class Library project will be public by default.
    //For any subsequent classes, you will need to update their access modifier.

    //Verbal Description of the Code
    //This is a public, inheritance-only class (abstract keyword) called Employee that extends
    //the Person class and it implements the IPayable and IDirectDepositable interfaces.
    
    //** You could remmove the reference to IPayable here because you get its
    //implementation via inheritance through IDirectDepositable. Leaving it here 
    //does not hurt performance and it gives an extra element to "self-documenting code". **

    public abstract class Employee : Person, IPayable, IDirectDepositable
    {
        //FIELDS
        //None - FirstName, LastName, and DOB are already here (inherited from Person)
        //We can add additional fields IF we need custom business rules.
        //If you don't require custom business rules, you can use auto-properties.

        //PROPERTIES
        public int ID { get; /*set;*/ } //Setter commented out to make ID read-only

        public string JobTitle { get; set; }

        public DateTime DateOfHire { get; set; }

        public bool IsDirectDeposit { get; set; }


        //CONSTRUCTORS
        public Employee(int id, string fName, string lName, DateTime dob, string title, 
            DateTime hireDate, bool isDirectDeposit) : base(fName, lName, dob)
        {
            //Assignment
            this.ID = id;
            this.JobTitle = title;
            this.DateOfHire = hireDate;
            this.IsDirectDeposit = isDirectDeposit;

        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            return string.Format(
                $"ID: {ID}\n{base.ToString()}\nJob Title: {JobTitle}\nDate of Hire: {DateOfHire:d}\n" +
                //Ternary Operator: 3 Parts
                //[Condition] ? [True] : [False]
                $"Direct Deposit: {(IsDirectDeposit ? "Enabled" : "Disabled")}");
        }

        //Added the below code AFTER implementing the IPayable interface
        public string GetNameForPaycheck()
        {
            return FirstName + " " + LastName;
        }

        //We do not have the appropriate information to generate or
        //calculate a paycheck here. Thankfully, by declaring the
        //method below as ABSTRACT, we can "pass the buck" to any
        //inheriting classes so THEY can implement the method behavior
        //while still satisfying IPayable's contract here.

        public abstract decimal GetPaycheckAmount();

        public string GetBankingInfo()
        {
            /*
             * Banking information can include (but is not limited to):
             * Account numbers, Routing numbers, institution name, PIN, password, etc.
             * These should all be fields/properties in the Employee class.
             * Our example here is much more basic and will simply hard code this info.
             * That means ALL banking information will be the same for EVERY employee.
             */

            return "Bank of 'Merica | 00011123 | 45678987654";
        }

    }//end class
}//end namespace
