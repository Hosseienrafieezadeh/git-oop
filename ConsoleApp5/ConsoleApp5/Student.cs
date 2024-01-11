using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public class Student:IStudent
    {
        
        private string _name { get; set; }
        private int _StudentID { get; set; }
        public string Name { get { return _name; } set 
            {
                if (value.Length>120)
                {
                    throw new Exception("the name cannot more than 120 char");
                }
                _name = value;
            }
        }
            public  int StudentID { get { return _StudentID; } set 
            {
                if (value.ToString().Length>=11)
                {
                    throw new Exception("Its number should not be more than 11");
                }
                _StudentID = value;
            }
        }
        public virtual void ShowStudentsInformation() 
        {
            Console.WriteLine($"Student name:{Name} - studentID:{StudentID}");
        }
    }
}
