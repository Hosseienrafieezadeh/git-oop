using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public static class Oop
    {
        private static List<Student> _students = new();

        public static void AddStudent(string name, int studentid, int type, string majorOrCourse)
        {
            switch (type)
            {
                case 1:
                    var student = new Student { Name = name, StudentID = studentid };
                    _students.Add(student);
                    break;
                case 2:
                    var studentCollge = new StudentsOfUniversity { Name = name, StudentID = studentid , Major = majorOrCourse };
                    _students.Add(studentCollge);
                    break;
                case 3:
                    var onlinestudent = new OnlineStudents { Name = name, StudentID = studentid , Course = majorOrCourse };
                    _students.Add(onlinestudent);
                    break;
                default:
                    throw new ArgumentException("Invalid student type");
            }


        }
        
        public static void ShowStudent() 
        {
            Console.WriteLine("**********************************");
            foreach (var item in _students)
            {
              
                item.ShowStudentsInformation();
            }
            Console.WriteLine("**********************************");
        }
    }
}
