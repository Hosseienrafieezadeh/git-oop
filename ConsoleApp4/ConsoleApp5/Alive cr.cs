using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  public  class Alive_cr :Charecter
    {
        public Alive_cr( string name):base(name)
        {

        }

        public override void PowerSet(int power)
        {
            base.PowerSet(power);
        }
        public override void SpeedSet(int speed)
        {
            base.SpeedSet(speed);
        }
    }
}
