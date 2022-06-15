using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPayroll
{
    //class : interface = Implementation of an interface
    //interface : interface = Inheritance
    public interface IDirectDepositable : IPayable
    {
        //From inheritance, we get:
        //GetNameForPaycheck
        //GetPaycheckAmount
        string GetBankingInfo();
    }
}
