using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_5_2
{
    internal class Rectangle
    {
        public double side1;
        public double side2;

        public double Square()
        {
            return side1*side2;
        }

        public double Perimeter()
        {
            return (side1+side2) * 2;
        }
    }
}
