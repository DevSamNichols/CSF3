
namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i <= 1000; i++)
            {
                //Console.WriteLine(i);
                if (i % 3 == 0 || i % 5 == 0)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine(list.Sum());

        }//end main

    }//end class

}//end namespace