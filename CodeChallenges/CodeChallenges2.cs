using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    public class CodeChallenges2
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            int int1 = 0;

            int int2 = 1;

            int int3;

            Console.WriteLine($"{int1}\n{int2}");

            for (int i = 0; i < 10000; i++)
            {

                int3 = int1 + int2;

                if (int3 >= 4000000) //Catches
                {
                    continue; //Exit the for loop
                }

                Console.WriteLine(int3); //Prints the Fibonacci

                int1 = int2;

                int2 = int3;

                if (int3 % 2 == 0) //Finds the sum of the even-valued terms
                {
                    list.Add(int3);
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine(list.Sum()); //prints the sum of the even valued terms

        }
    }
}
