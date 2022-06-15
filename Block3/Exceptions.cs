using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class Exceptions
    {
        static void Main(string[] args)
        {

            //Exception: Anything that interrupts the normal execution of an assembly
            //Assembly: We see them as VS projects. An assembly is just a set of routines
            //that are used to perform a specific function.

            //Exception Handling: Internally, in the code we can use Try/Catch/Finall

            //Try: Code to test/check for errors. "Potentially dangerous code" -
            //the outcome of its execution is unknown.

            //Catch: Handle the exception. Catch blocks should cascade from the MOST
            //specific types of exceptions to the LEAST specific exceptions.

            //Finally: Always executes and can be used to return resources to the
            //runtime environment for use. (File stream, data reader, SQL connection, documents, etc.)

            try
            {

                #region Default Exception Information

                //Create a basic exception and throw it
                //Exception e = new Exception(); //Default constructor
                //Exception e = new Exception("This is a custom Exception message!");

                //Add a definition for the data property:
                //e.Data.Add(111, "This is an example of developer-defined custom data");



                //throw e;

                #endregion

                //Test the default InsufficientFundsException
                //InsufficientFundsException e = new InsufficientFundsException();

                //Test the qualified InsuffiecientFundsException
                InsufficientFundsException e = new InsufficientFundsException("You ain't got that money honey!");

                throw e;

            }

            catch (DivideByZeroException dbze)
            {
                Console.WriteLine($"Divide By Zero: {dbze.Message}");
            }

            catch (NullReferenceException nre)
            {
                Console.WriteLine($"Null Reference: {nre.Message}");
            }

            catch (FormatException fe)
            {
                Console.WriteLine($"Format: {fe.Message}");
            }

            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine($"Index Out of Range: {ioore.Message}");
            }

            catch (InsufficientFundsException ife)
            {
                Console.WriteLine($"Insufficient Funds: {ife.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine("********* Exception Properties *********");
                //Source - Project/Assembly that threw the exception
                Console.WriteLine($"Source: {ex.Source}\n");

                //Message - Default messagin defining the data type of the exception
                Console.WriteLine($"Message: {ex.Message}\n");

                //StackTrace - Project.ClassName.Method AND the physical file location,
                //including the line number that threw the exception
                Console.WriteLine($"Stack Trace:\n {ex.StackTrace}\n");

                //Data - Any developer-defined data in a key/value pair
                Console.WriteLine($"Data: {ex.Data[111]}\n");

                //ToString() - Combination of the Source, Message, and Stack Trace properties
                Console.WriteLine($"ToString(): \n{ex.ToString()}\n");

            }//end catch

            finally
            {
                Console.WriteLine("This code always executes.");

                //The finally block is most commonly used to release
                //resources that may have been trapped in the catch
                //(when the operation failed).
            }

        }//end main

        //You can create your own, custom exceptions!
        //ALL Exceptions should include the word "Exception" in the name
        //and MUST inherit from the Exception class
        public class InsufficientFundsException : Exception
        {

            //Fields
            private string _message = "Your request for funds exceeds your account balance.";

            //Properties
            public override string Message
            {
                get { return _message; }
            }

            //Constructors
            public InsufficientFundsException() { }

            public InsufficientFundsException(string message)
            {
                _message = message;
            }

            //Methods
            //ToString()

        }

    }//end class
}//end namespace
