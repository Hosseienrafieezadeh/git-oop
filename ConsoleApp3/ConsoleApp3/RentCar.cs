using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  public  class RentCar : Car
    {
        public RentCar(string name) : base(name)
        {


        }
        public int RentCount { get; private set; }
        public override void SetCount(int count)
        {
            if (count == 1)
            {
                Console.WriteLine("We have one more car left");
            }
            if (count == 0)
            {
                throw new Exception("This car is not available for rent");
            }
            base.SetCount(count);

        }
        public void Rent()
        {
            if (Count == 0)
            {
                throw new Exception();
            }

            RentCount++;
            var newCount = Count;
            SetCount(--newCount);
        }
    }
}
