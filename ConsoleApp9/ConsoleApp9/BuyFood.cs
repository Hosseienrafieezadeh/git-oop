using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
     public class BuyFood
    {
        public BuyFood( Customer customer ,string foodName)
        {
            Customer = customer;
            FoodName = foodName;
        }
        public Customer Customer { get; set; }
        public string FoodName { get; set; }
        
    }
}
