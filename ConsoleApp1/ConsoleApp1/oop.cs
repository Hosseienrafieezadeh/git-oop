using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public static  class oop
    {
        private static List<Person> _person = new();
        public static void AddfullName( string firstName,String lastName) 
        {
            var fullname = new Person(firstName, lastName);
            _person.Add(fullname);
            Console.WriteLine("************************");
            Console.WriteLine($"fullname:{Person.GetFullName(firstName, lastName)}");
            Console.WriteLine("************************");
        }
    }
}
