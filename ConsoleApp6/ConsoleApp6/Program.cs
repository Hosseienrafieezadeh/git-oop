using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static   IBook bookManager = new Manger ();
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
        
            static void Run()
            {

                var option = AddInt("1:add book \n2:Remove Book \n3: Display All Books");
                switch (option)
                {
                    case 1:
                        {
                            var name = AddString("write name");
                            var type = AddInt("1_salebook -  2_RentBook");
                            var bookID = AddInt("Write StudentID");
                            var price = AddInt("enter price");
                            var count = AddInt("enter count");
            
                            bookManager.AddBook(name, type, price, count, type);

                            break;
                         }
                    case 2:
                        {
                         
                            var bookID = AddInt("Write StudentID");
                            bookManager.RemoveBook(bookID);
                            break;
                        }
                    case 3:
                        {
                            bookManager.DisplayAllBook();
                            break;
                        }
                    default:
                        break;
                }
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
