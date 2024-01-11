using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class OnlineStudents:Student
    {
        public string Course { get; set; }

        public override void ShowStudentsInformation()
        {

            base.ShowStudentsInformation();
            Console.WriteLine($"  curse:{Course}" );
        }
    }
}
