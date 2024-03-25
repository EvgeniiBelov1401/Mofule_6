using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_2_2
{
    internal class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        public Pen(string penColor,int penCost)
        {
            color= penColor;
            cost = penCost;
        }
    }
}
