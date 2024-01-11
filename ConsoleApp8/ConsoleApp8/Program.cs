using System;

namespace ConsoleApp8
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
            var option = AddInt("1:add Task \n2:Show Task");
            switch (option)
            {
                case 1:
                    {

                        var type = AddInt("1_NormalTask -  2_HighPrioityTask");

                        

                        var title = AddString("title:");

                        var priority = AddInt("Priority:");
                        var days = AddInt("days to projects:");

                        Oop.ADDTasks(type, title, priority, days);

                        break;
                    }
                case 2:
                    {

                        Oop.ShowTasks();
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

