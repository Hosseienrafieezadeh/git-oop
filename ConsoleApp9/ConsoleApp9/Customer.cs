using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
   public class Customer:person
    {
        private List<BuyFood> _buyFoods;
        private  string _phonenumber { get; set; }
        public int Payment { get; set; }
        public Customer(string name):base (name)
        {
            _buyFoods = new();
        }
        public void SetBuyFood( Food food) 
        {
            _buyFoods.Add(new BuyFood(this, food.Name));
        }
        public List<BuyFood> GetUserRentCars()
        {
            return _buyFoods;
        }
        public string PhoneNumber { get { return _phonenumber; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                         value.Length != 11 ||
                         !value.StartsWith("09")) 
                {
                    throw new Exception("eror start with 09 or 11char");
                }

                _phonenumber = value;
            }
        }

    }
}
