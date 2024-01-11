using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Hero:Charecter
    {
        public Hero( string name):base (name)
        {

        }
        public override void SpeedSet(int speed)
        {
            base.SpeedSet(speed);
        }
        public override void PowerSet(int power)
        {
            
            base.PowerSet(power);
        }
    }
}
