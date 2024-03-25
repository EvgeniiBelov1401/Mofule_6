using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_2_0_3
{
    internal class Human
    {
        public string name;
        public int age;

        public void Greeting()
        {
            Console.WriteLine($"Меня зовут {name}, мой возраст: {age}");
        }
    }
}
