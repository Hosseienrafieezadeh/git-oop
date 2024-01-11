using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
      public class Food
    {
        public Food( string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int  Price { get;private set; }
        public virtual void SetPrice(int price)
        {
            if (price < 0)
            {
                throw new Exception("The price cannot be less than zero");
            }

            Price = price;
        }

    }
}
