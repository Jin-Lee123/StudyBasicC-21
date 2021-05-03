using System;

namespace TEST_03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"*");

                }

                Console.WriteLine();
                if (i == 5)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
