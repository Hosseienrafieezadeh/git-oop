using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public Person( string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        public string FirstName {
            get { return _firstName; }
            set { if (value.Length >= 50)
                {
                    throw new Exception("the char cannot more 50 char");
                }
                value = _firstName;
            } }
        public string LastName { get { return _lastName; } set
            {
                if (value.Length >= 70)
                {
                    throw new Exception("the char cannot more 70 char");
                }
                value = _lastName;
            }


        }
            public static string GetFullName(string firstName, string lastName)
            {
             return firstName       +            lastName;
            }
    }
}
