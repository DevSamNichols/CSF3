namespace BranchingAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //BRANCHING LOGIC
            //Two Options: If and Switch

            //If: Excellent for dealing with ranges

            int userScore;

            Console.Write("Please enter your test score: ");
            userScore = int.Parse(Console.ReadLine());

            if (userScore >= 90)
            {
                Console.WriteLine("\nYou got an A!");
            }
            //The code below will never run
            else if (userScore == 90)
            {
                Console.WriteLine("\nThis code will NEVER run");
            }

            else if (userScore >= 80)
            {
                Console.WriteLine("\nYou got a B!");
            }
            else if (userScore >= 70)
            {
                Console.WriteLine("\nYou got a C!");
            }
            else if (userScore >= 60)
            {
                Console.WriteLine("\nYou got a D!");
            }
            else
            {
                Console.WriteLine("\nYou got a F");
            }

            //Both of these can happen
            if (userScore >= 50)
            {
                Console.WriteLine("\nYou got at least half of the available points.");
            }

            if (userScore > 0)
            {
                Console.WriteLine("\nYou scored some points");
            }


        }//end main
    }//end class
}//end namespace