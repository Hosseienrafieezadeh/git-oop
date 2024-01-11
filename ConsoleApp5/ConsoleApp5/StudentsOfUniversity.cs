using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public class StudentsOfUniversity:Student
    {
        public string Major { get; set; }
        public override void ShowStudentsInformation()
        {
            base.ShowStudentsInformation();
            Console.WriteLine($"Student name:{Name} - studentID:{StudentID} - major:{Major}");
        }
    }
}
