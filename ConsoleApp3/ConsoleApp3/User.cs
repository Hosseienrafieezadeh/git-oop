using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  public class User
    {
        private List<UserRentCar> _userRentCars;
        
        public User( string name)
        {
            Name = name;
            _userRentCars = new();
        }
        public string Name { get; set; }

        public void SetRentCar( Car car) 
        {
            _userRentCars.Add(new UserRentCar(this, car.Name));
        }
        public List<UserRentCar> GetUserRentCars()
        {
            return _userRentCars;
        }
    }
}
