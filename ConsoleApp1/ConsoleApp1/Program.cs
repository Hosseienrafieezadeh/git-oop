using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
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
           
            var firstName = AddString("firstname");
            var lastName = AddString("latname");
            oop.AddfullName(firstName, lastName);
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
