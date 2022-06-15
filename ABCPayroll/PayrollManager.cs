using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPayroll
{
    //Even though we don't see it, Object is the base class unless otherwise specidied
    public class PayrollManager // : Object
    {
        //Fields

        //Properties

        //Constructors

        //Methods

        public static void ProcessPaycheck(IPayable target)
        {
            /*
             * To process a paycheck, we must ensure that the object passed to 
             * the method implements the appropriate interface methods. In order
             * to provide the details necessary to process a paycheck, we will
             * need to supply this method with an instance of an object that
             * fulfills the requirements for IPayable. That instance of an object
             * is the recipient of the action, hence the name "target" here.
             * 
             * This method SIMULATES the issuance of a paycheck by outputting to the 
             * console. If we really intended to process a paycheck, we would need
             * to process the values and send them to a 3rd party that handles payroll
             * (paychex or ADP as examples). We could also send the data to a 3rd party
             * API that handles the printing of the paycheck, such as QuickBooks.
             */

            Console.WriteLine(
                $"A paper check has been issued to {target.GetNameForPaycheck()}.\n" +
                $"The amount paid was: {target.GetPaycheckAmount():c}."
                );
        }//end ProcessPaycheck()

        public static void DoDirectDeposit(IDirectDepositable target)
        {
            //Simulate the EFT to the financial institution by writing to the console
            Console.WriteLine(
                $"{target.GetNameForPaycheck()} was paid " +
                $"{target.GetPaycheckAmount():c}.\n" +
                $"The funds were transferred to {target.GetBankingInfo()}."
                );
        }//end DoDirectDeposit()

    }//end class
}//end namespace
