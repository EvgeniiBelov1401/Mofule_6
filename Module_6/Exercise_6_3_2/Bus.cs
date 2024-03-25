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
        public bool? HasLoad;

        public void PrintStatus()
        {
            if (HasLoad==true && Load>0)
            {
                Console.WriteLine($"В автобусе {Load} пассажиров");
            }
            else
            {
                Console.WriteLine($"Автобус пустой");
            }
        }
        public Bus(Load load)
        {
            Load=load.Value;
            HasLoad=load.HasValue;
        }


    }
}
