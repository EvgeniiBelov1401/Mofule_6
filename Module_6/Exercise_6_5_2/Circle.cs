using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_5_2
{
    internal class Circle
    {
        public double radius;

        public double Square()
        {
            return Math.PI*Math.Sqrt(radius);
        }

        public double Perimeter()
        {
            return 2+Math.PI*radius;
        }
    }
}
