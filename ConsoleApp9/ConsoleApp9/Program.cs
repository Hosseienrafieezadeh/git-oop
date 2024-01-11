using System;

namespace ConsoleApp9
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
                var option = AddInt("1:add Person \n2:Show persn\n3:add food \n4:show Food \n5:buy food \n6:show buys list");
            switch (option)
            {
                case 1:
                    {
                        var type = AddInt("1_Person -  2_Customer");
                        var name = AddString("write person Name");
                        var phonenumber = AddString("write person phone number");
                        Oop.AddPerson(type, name, phonenumber);
                        break;
                    }
                case 2:
                    {

                        foreach (var per in Oop.GetPerson())
                        {
                            Console.WriteLine($"{per.Name}");
                        }
                        break;
                    }
                case 3:
                    {
                        var type = AddInt("1_FastFood -  2_Traditional");
                        var name = AddString("write person Name");
                        var price = AddInt("write price");
                        Oop.AddFood(type, price, name);
                        break;
                    }
                case 4:
                    {
                        Oop.ShowFood();
                        break;
                    }
                case 5: 
                    {
                        var name = AddString("write food Name");
                        var phonenumber = AddString("write person phonenumber:");
                        Oop.BuyFood(name,phonenumber); 
                        break;
                    }
                case 6: 
                    {
                        Oop.showCustomerBuy();
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


