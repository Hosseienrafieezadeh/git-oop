using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Manager:Employee
    {
        public string Departmentt { get; set; }
        public override void PeintDetalis()
        {
            base.PeintDetalis();
            
            Console.WriteLine($"manger ID:{EmployeeID} -  department:{Departmentt}");
            
        }
    }
}
