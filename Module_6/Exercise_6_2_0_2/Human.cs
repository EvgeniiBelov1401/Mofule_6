using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_2_0_2
{
    internal class Human
    {
        public string name;
        public int age;

        public void Greetings()
        {
            Console.WriteLine($"Меня зовут {name}, мой возраст: {age}\n");
        }

        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }

        public Human(string n)
        {
            name=n;
            age = 20;
        }

        public Human(string n,int a)
        {
            name = n;
            age = a;
        }
    }
}
