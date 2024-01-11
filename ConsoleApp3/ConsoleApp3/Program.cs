using System;

namespace ConsoleApp3
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
        static void Run() {
            var option = AddInt("1:add cars\n2:show cars\n3:add user\n4:Rent car\n5:show user rent cars");
            switch (option)
            {
                case 1: 
                    {
                        var type = AddInt("1_car - 2_for rent");
                        var name = AddString("write car name");
                        var count = AddInt("write count");
                        var model = AddInt("write model");
                        Oop.AddCars(type,name,count,model);
                        break; 
                    }
                case 2: 
                    {
                        Console.WriteLine("allcars:");
                        Console.WriteLine("***************************************");
                        foreach (var car in Oop.Getcars())
                        {
                            var carOrRent = car is RentCar ? "yes" : "no ";
                            Console.WriteLine($"Name:{car.Name} - model{car.Model } - count:{car.Count} - for rent:{carOrRent}");
                        }
                        Console.WriteLine("***************************************");
                        break;
                    }

                case 3:
                    {
                        var userName =AddString("enter userName");
                        Oop.AddUser(userName);
                        break;
                    }
                case 4: 
                    {

                        var userName = AddString("enter userName");
                        var carName = AddString("enter car name");

                        Oop.RentCar(carName, userName);
                        break;
                        
                    }
                case 5:
                    {
                        Oop.ShowUser();    
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
