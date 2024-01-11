using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  public  class UserRentCar
    {
        public UserRentCar( User user,string carName)
        {
            User = user;
            CarName = carName;
            Date = DateTime.Now;
        }
        public User User { get; set; }
        public string CarName { get; set; }
        public DateTime Date { get; set; }
    }
}
