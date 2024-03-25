using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_2_8
{
    internal class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        {
            return a * b;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int x,int y)
        {
            a=x; 
            b=y;
        }

        public Rectangle(int x)
        {
            a = x;
            b = x;
        }
    }

    
}
