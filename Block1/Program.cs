using Block1Library;

using ABCPayroll;

namespace Block1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and output an hourly employee object
            HourlyEmployee he = new HourlyEmployee(222, "Kyle", "Anderson", new DateTime(1988, 4, 21),
                "Gopher", new DateTime(2011, 1, 1), false, 40, 11.95m);
            Console.WriteLine(he);

            //MINI-LAB!
            //Create a SalariedEmployee object and a Manager object.
            //Once created, output them to the console.

            //Salaried Employee
            SalariedEmployee se = new SalariedEmployee(333, "Chuck", "Larabee", new DateTime(1967, 7, 16),
                "Security Expert", new DateTime(2011, 1, 1), true, 52000);
            Console.WriteLine("\n" + se);

            //Manager
            Manager m = new Manager(444, "Ed", "Alzate", new DateTime(1936, 12, 22), "Owner",
                new DateTime(2011, 1, 1), false, 150000, 25000);
            Console.WriteLine("\n" + m);

            //PayrollManager / ABCPayroll Testing
            Console.WriteLine("\n*******************  Hourly Employee Paper Check  *******************\n");
            PayrollManager.ProcessPaycheck(he);

            Console.WriteLine("\n*******************  Salaried Employee Direct Deposit  *******************\n");
            PayrollManager.DoDirectDeposit(se);

            Console.WriteLine("\n*******************  Manager Employee Paper Check  *******************\n");
            PayrollManager.ProcessPaycheck(m);

            //It would be cumbersome to create lists of employees by their respective types
            //if we wanted to pay everyone at the same time. It's much easier and more flexible
            //if we have a single defined type by which we can group all employees.

            List<Employee> employees = new List<Employee>() { he, se, m };

            //POLYMORPHISM

            //Loop through the Employee list and pay them as necessary:

            foreach (Employee x in employees)
            {
                if (x.IsDirectDeposit)
                {
                    PayrollManager.DoDirectDeposit(x);
                }
                else
                {
                    PayrollManager.ProcessPaycheck(x);
                }
                Console.WriteLine("\n");
            }

            //How many different implementations do we have for the Manager object
            //Manager
            //Salaried Employee
            //Employee
            //Person
            //Object
            //IPayable
            //IDirectDepositable

            //1 object with 7 different potential implementations ("forms") - Polymorphism

        }
    }
}