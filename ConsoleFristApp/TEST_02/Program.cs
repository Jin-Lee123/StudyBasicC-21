using System;

namespace TEST_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 :");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 :");
            string age = Console.ReadLine();
            Console.Write("주소을 입력하세요 :");
            string adress = Console.ReadLine();

            Console.WriteLine("반갑습니다. 저는 " + adress + "에 살고있는" + age + "살 " + name + "입니다.");
        }
    }
}
