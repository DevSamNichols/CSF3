namespace ABCPayroll
{
    #region Interface Notes
    /* - This started as a free class when we created the class library.
    *    We overtyped the class declaration with the interface keyword.
    *  - Any class that wants to use this set of rules MUST Implement
    *    the interface at the class level AND satisfy the requirements
    *    in the body of the class. 
    *  - We can implement as many interfaces as are required as opposed
    *    to inheritance where we can only Inherit ONE CLASS directly. 
    *  - Implementation of the interface at the class level creates a 
    *    CONTRACT that says if you want to be "a kind of" the interface
    *    you MUST satisfy these requirements
    *  - Interfaces MUST be public.
    *  - IsomethingABLE is the naming convention (.NET)
    * 
    * **************When and How to implement interfaces****************
    * 1. When you have objects that MUST conform to a set of rules/
    * specifications AND there are no other obvious links between 
    * the classes, then an interface should be used. This will give
    * you AND other coders a compiler enforced set of rules.
    * 
    * 2. Create the interface structure. It is usually more than one
    * interface and should be contained in its own class library.
    * 
    * 3. Implement the interface at the lowest level of commonality
    * between the classes (at the class level) AND only classes
    * that MUST conform to these specifications.
    * 
    * 4. Once the interface is implemented at the class level, satisfy
    * ALL of the interface requirements inside the body of the class.
    * 
    * 5. TEST!
    * 
    * 6. Check for any logic errors (inheritance or calculations)
    * 
    */
    #endregion

    public interface IPayable
    {
        //Basic steps for implementing an Interface
        //1) Create the interface
        //2) Implement the interface at the class level (Employee)
        //3) Implement the Interface members inside the class (Adding methods to Employee.cs's body)

        //CONTRACT - Method to get the name for a paychack and a Method to get the paycheck amount.

        string GetNameForPaycheck();

        decimal GetPaycheckAmount();

        //The above LOOK like methods, but they are incomplete.
        //They have NO access modifier becase this contract says you MUST have a Method with this name.
        //They also have NO functionality -- the functionality is determined by the code in the class
    }
}