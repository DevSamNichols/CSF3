using Block1Library;

namespace Block3
{
    class SequentialCollections
    {
        static void Main(string[] args)
        {

            #region Hourly Employee Objects

            //Create 5 HourlyEmployee objects to use in this file
            HourlyEmployee he1 = new HourlyEmployee(111, "Mike", "Baxter", new DateTime(1963, 06, 03),
                "Marketing Genuis", new DateTime(2011, 1, 1), true, 40, 40.25m);

            HourlyEmployee he2 = new HourlyEmployee(222, "Kristin", "Baxter", new DateTime(1967, 08, 27),
                "Restaurant Manager", new DateTime(2011, 1, 1), false, 40, 30.15m);

            HourlyEmployee he3 = new HourlyEmployee(333, "Ed", "Alzate", new DateTime(1937, 12, 25),
                "Business Owner", new DateTime(2011, 1, 1), true, 40, 60.25m);

            HourlyEmployee he4 = new HourlyEmployee(444, "Kyle", "Anderson", new DateTime(1988, 04, 21),
                "Gopher", new DateTime(2011, 1, 1), false, 60, 10.50m);

            HourlyEmployee he5 = new HourlyEmployee(555, "Chuck", "Larabee", new DateTime(1967, 05, 13),
                "Security Manager", new DateTime(2011, 1, 1), true, 40, 27.75m);

            #endregion

            #region Sequential Collections

            /*
             * Sequential Collections: Stack and Queue
             * 
             * Stack is LIFO - Last In, First Out
             * Stack could be used for:
             *      - Undo Functionality (Ctrl + Z)
             *      - Back button in a browser
             *      
             *      - Push() adds an object to the stack
             *      - Pop() removes an object from the stack
             *      - Peek() views the object at the TOP of the stack WITHOUT removing it
             *      
             * Queue is FIFO - First In, First Out
             * Queue could be used for:
             *      - Call center software
             *      - Joining a server in a game
             *      - Order fulfillment
             *      - Ticketing systems
             *      
             *      - Enqueue() adds to an object to the queue
             *      - Dequeue() removes an object from the queue
             *      - Peek() views the object at the front of the queue WITHOUT removing it
             *      
             * Because the order of entry of each object is so important to both
             * of these types of collections, there is NO initialization syntax.
             *      
             */

            #endregion

            /********************** Stack<T> **********************/
            //Create a stack to store HourlyEmployee objects
            Stack<HourlyEmployee> empStack = new Stack<HourlyEmployee>();
            //Without collection initialization syntax
            empStack.Push(he4);
            empStack.Push(he1); 
            empStack.Push(he2);

            //To view the top of the stack, use Peek()
            Console.WriteLine(empStack.Peek()); //he2
            Console.WriteLine(empStack.Pop()); //he2
            Console.WriteLine(empStack.Peek()); //he1

            //We also have access to Clear(), which empties the stack without
            //any processing.
            empStack.Clear();

            /********************** Queue<T> **********************/
            //Used whenever processing should occur by order of the request.
            Queue<HourlyEmployee> qEmps = new Queue<HourlyEmployee>();
            //No initialization syntax
            qEmps.Enqueue(he3);
            qEmps.Enqueue(he1); 
            qEmps.Enqueue(he2);

            Console.WriteLine("\n\n");

            Console.WriteLine("Employee Queue Results:");

            Console.WriteLine(qEmps.Peek()); //he3
            Console.WriteLine(qEmps.Dequeue()); //he3
            Console.WriteLine(qEmps.Peek()); //he1

            //Stack and Queue Trickery with Exams
            int Five = 1;
            int Four = 2;
            int Three = 4;
            int Two = 3;
            int One = 5;

            Queue<int> q = new Queue<int>();
            q.Enqueue(One);
            q.Enqueue(Two);
            q.Enqueue(Three);
            q.Enqueue(Four);
            q.Enqueue(Five);

            Console.WriteLine("\n\nQueue Results:");

            Console.WriteLine(q.Peek()); //Item: One | Value: 5

            //The important thing to understand with exam questions based on
            //stacks and queues -- Which type of collection are they using (FIFO / LIFO)
            //AND which part of the answer do they want (itemName / value).

            q.Clear();
            //Clear() abandons ALL items in the collection AND the order in which they
            //were entered.

        }
    }
}