using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_3_2
{
    internal class Bus
    {
        public int? Load;
        public bool? HasValue;

        public void PrintStatus()
        {
            if (HasValue==true && Load>0)
            {
                Console.WriteLine($"В автобусе {Load.Value} пассажиров");
            }
            else
            {
                Console.WriteLine($"Автобус пустой");
            }
        }
        public Bus(bool hasValue,int value)
        {
            HasValue = hasValue;
            Load = value;
        }


    }
}
