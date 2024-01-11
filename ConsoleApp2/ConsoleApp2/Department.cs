using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public  class Department
    {
        public Department(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<Manager> Managers { get; set; }
        
    }
}
