using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Oop
    {
        private static List<Car> _cars = new();
        private static List<User> _users = new();
        public static void AddCars(int type,string name,int count,int model) 
        {
            if (type==1)
            {
            var car = new Car(name);
            car.SetCount(count);
            car.Model = model;
            _cars.Add(car);
            }
            if (type == 2) 
            {
                var rentCar = new RentCar(name);
                rentCar.SetCount(count);
                rentCar.Model = model;
                _cars.Add(rentCar);
            }

        }
        public static void AddUser(string userName)
        {
            var user = new User(userName);

            _users.Add(user);
        
        }
        public static void RentCar(string carName, string userName)
        {
            var car =_cars.Find(_ => _.Name == carName);

            var user = _users.Find(_ => _.Name == userName);

            var rentCar = car as RentCar;
            rentCar.Rent();
            user.SetRentCar(car);
        }
        public static void ShowUser() 
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"username:{user.Name}");
                foreach (var item in user.GetUserRentCars())
                {
                    Console.WriteLine($"username:{item.User} - cartorent:{item.CarName} -  time to rent{item.Date}");
                }
            }
        }

        public static List<Car> Getcars() 
        {
            return _cars;
        }
    }
}
