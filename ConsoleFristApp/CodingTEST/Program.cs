using System;


namespace CodingTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 7; i < 10; i++)
            {
                Console.WriteLine(i+"단 계산 시작");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{ i } * { j } = { i * j } ");
                }
                Console.WriteLine();
            }
            

            /*for (int i = 1; i < 11; i++)
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
            }*/

            /*Console.WriteLine("이름을 입력하세요 :");
            string name = Console.ReadLine();
            Console.WriteLine("나이를 입력하세요 :");
            string age = Console.ReadLine();
            Console.WriteLine("주소을 입력하세요 :");
            string adress = Console.ReadLine();

            Console.WriteLine("저는 " + adress + "에 살고있는" + age + "살 " + name + "입니다.");*/


            /* Console.WriteLine("원의 반지름 값을 입력하세요 :");
             string input = Console.ReadLine();

             float result = float.Parse(input);
             Console.WriteLine($"원의 넓이는  { result*result*pi }  ");*/

            /*try
            {  //예외가 발생할 가능성 있는 로직
                Console.WriteLine("값을 입력하세요(소수점을 입력) :");
                string input = Console.ReadLine();
                float result = float.Parse(input);   //예외발생위치
                Console.WriteLine($"입력된 값은  { result }  입니다");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외 발생 : {ex.StackTrace}");
            }*/






        }
    }
}
