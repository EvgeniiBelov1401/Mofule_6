using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_3_1
{
    internal class Department
    {
        public Company Company;
        public City City;

        public Department(Company depCompany,City depCity)
        {
            Company = depCompany;
            City = depCity;
        }
    }
}
