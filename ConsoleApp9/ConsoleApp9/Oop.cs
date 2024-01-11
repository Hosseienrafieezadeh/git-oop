using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public static  class Oop
    {
        private static List<person> _person = new();
        private static List<Food> _Food = new();
        private static List<Customer> _customers = new();

        public static void AddPerson(int type,string phonenumber,string name) 
        {
            switch (type)
            {
                case 1:
                    {
                        var person = new person(name);
                        _person.Add(person);
                        break;
                    }
                case 2:
                    {
                        var customer = new Customer(name);
                        customer.PhoneNumber = phonenumber;
                        _person.Add(customer);
                        break;
                    }

                default:
                    
                    break;
            }
         

        }
        public static void AddFood(int type, int price, string name)
        {
            switch (type)
            {
                case 1:
                    {
                        var fastfood = new FastFood(name);
                        fastfood.SetPrice(price);
                        _Food.Add(fastfood);
                        break;
                    }
                case 2:
                    {
                        var Tradital = new Traditional(name);
                        Tradital.SetPrice(price);
                        _Food.Add(Tradital);
                        break;
                    }

                default:

                    break;
            }


        }
        public static void BuyFood(string foodName, string phonenumber)
        {
            var food = _Food.Find(_ => _.Name == foodName);
            if (food is null)
            {
                throw new Exception("not found this food");
            }
            var user = _customers.Find(_ => _.PhoneNumber == phonenumber);
            if (user is null)
            {
                throw new Exception("not found this food");
            }
            user.Payment += food.Price;
            user.SetBuyFood(food);
        }
        
        public static void showCustomerBuy() 
        {
            Console.WriteLine("_________________________________________________________");
            foreach (var customer in _customers)
            {
                Console.WriteLine($"name:{customer.Name} - phonenumber:{customer.PhoneNumber } - payment:{customer.Payment}");
            }
            Console.WriteLine("__________________________________________________________");
        }
        public static void ShowFood() 
        {
            Console.WriteLine("All FOOD");
            foreach (var food in GetFood())
            {
                var foodfastortr = food is FastFood ? "fastfood" : "traditional";
                if (food is FastFood)
                {
                    Console.WriteLine("****************fastfood******************");
                    Console.WriteLine($"FoodName{food.Name}{food.Price}");
                }
                if (food is Traditional)
                {
                    Console.WriteLine("****************Traditional******************");
                    Console.WriteLine($"FoodName{food.Name}{food.Price}");
                }
            }
        }
        public static List<Food> GetFood()
        {
            return _Food;
        }
        public static List<person> GetPerson() {
            return _person;
        }

    }
}
