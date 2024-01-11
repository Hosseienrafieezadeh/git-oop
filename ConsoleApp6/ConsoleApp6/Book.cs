using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
 public class Book
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public decimal Price { get;private set; }

        public int Count { get; set; }
        public virtual void SetPrice(int price)
        {
            if (price < 0)
            {
                throw new Exception("The price cannot be less than zero");
            }

            Price = price;
        }

        public virtual void SetCount(int count)
        {
            if (count < 0)
            {
                throw new Exception("The count cannot be less than zero");
            }

            Count = count;
        }
        public virtual void DisplayInformation() 
        {

            Console.WriteLine($"Product ID: {BookID}, Name: {Name}, Price: {Price:C},count{Count}");
        }
    }
}
