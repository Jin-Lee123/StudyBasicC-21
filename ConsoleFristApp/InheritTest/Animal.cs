using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    //Access Modifier : pulic, protected, private
     class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("먹습니다"); }
        public void Sleep() { Console.WriteLine("잡니다"); }
    }
}
