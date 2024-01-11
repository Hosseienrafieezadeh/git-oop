using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception exception)
                {
                    ShowError(exception.Message);
                }
            }

        }
       static void Run() 
        {
            var option = AddInt("1:add student 2:Show Student");
            switch (option)
            {
                case 1: 
                    {
                        var type = AddInt("1_add student -  2_addCollge Student - 3_Online Student");
                        var name = AddString("write name");
                        var studentID = AddInt("Write StudentID");
                        var courseormajor = AddString("write course or major");
                        Oop.AddStudent(name,studentID,type,courseormajor);
                        break;
                    }
                case 2: 
                    {
                        Oop.ShowStudent();
                        break;
                    }
                default:
                    break;
            }
        }
        public static int AddInt(string messege)
        {
            int getIntegerValue;
            bool result;
            do
            {
                Console.WriteLine(messege);
                result = int.TryParse(Console.ReadLine(), out getIntegerValue);
            } while (!result);
            return getIntegerValue;
        }
        static void ShowError(string error)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(error);
            Console.WriteLine("-------------------");
        }
        public static string AddString(string messege)
        {
            string? result;
            do
            {
                Console.WriteLine(messege);
                result = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(result));
            return result;
        }

    }
}
