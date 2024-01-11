using System;

namespace ConsoleApp7
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
            var option = AddInt("1:add project 2:Show project");
            switch (option)
            {
                case 1: 
                    {
                        
                        var Type = AddInt("1_Software Development -  2_HardwareProject");
                        
                        var peojectID = AddInt("projectID?");
                        
                            var title = AddString("title:");
                        
                            var discription = AddString("discription");
                            var days = AddInt("days to projects:");

                        Oop.ADDprojects(Type, peojectID, title, discription, days);
                        
                        break;
                    }
                case 2:
                    {

                        Oop.ShowAllProject();
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
}
