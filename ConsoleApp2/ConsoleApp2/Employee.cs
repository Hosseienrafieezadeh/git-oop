using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Employee
    {
        public int EmployeeID { get; set; }
        public int Salary { get; set; }

        public virtual void PeintDetalis() 
        {
            Console.WriteLine($"ID:{EmployeeID} - salary:{Salary}");
        }
    }
}
