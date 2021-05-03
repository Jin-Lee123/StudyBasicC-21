using System;

namespace TEST_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9,! 3,6,9,! 3,6,9,! 3,6,9,! ");



            for (int i = 0; i < 101; i++)
            {
                if (i<=10)
                {
                    if(i%3==0)
                    {
                        Console.Write("짝!  ");
                    }
                    else
                    {
                        Console.Write($"{i}   ");
                    }
                }     
                if (i >10  )
                {
                    if ((i / 10) % 3 == 0)
                    {
                        Console.Write("짝!  ");
                    }
                    else
                    {
                        Console.Write($"{i}   ");
                    }
                    if (i % 15 == 0)
                    {
                        Console.Write('\n');
                    }
                }
                
    
            }



        }
    }
}
