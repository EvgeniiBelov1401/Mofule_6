using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_6_2
{
    internal class User
    {
        private string _login;
        private string _mail;

        public string Login
        {
            get { return _login; }
            set 
            { 
                if (_login.Length < 3)
                { 
                        Console.WriteLine("Логин не менее 3х символов");
                }
                else
                {
                    _login = value;
                }
                
            }
        }

        public string Mail
        {
            get { return _mail; }
            set 
            {
                if (value.Contains('@'))
                {
                    _mail = value;
                }
                else
                {
                    Console.WriteLine("Почта должна содержать @");
                }
            }
        }
    }
}
