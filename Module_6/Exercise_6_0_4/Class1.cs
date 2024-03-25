using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_0_4
{
    internal class Class
    {
        public int A 
        {
            get
            {
                return 5;
            }
           
        }
        public int B 
        { private get { return B; }
          set { B = value; } 
        }

        public int C {private get; set; }
    }
}
