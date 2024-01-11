using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public interface IStudent
    {
       public  string Name { get; set; }
       public  int StudentID { get; set; }
        void ShowStudentsInformation();
    }
}
