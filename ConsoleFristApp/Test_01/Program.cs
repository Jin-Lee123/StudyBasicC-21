using System;


namespace Test_01
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("원의 반지름 값을 입력하세요 :");
            string input = Console.ReadLine();

            float result = float.Parse(input);
            Console.WriteLine($"원의 넓이는  { result * result * (float)Math.PI }  ");
        }
    }
}
