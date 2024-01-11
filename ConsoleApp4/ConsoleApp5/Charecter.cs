using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  public abstract class Charecter
    {
        protected Charecter( string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Speed { get;private set; }
        public int Power { get;private set; }
        public int Helth { get;private set; }
        public Status Status { get; set; }
        public virtual void SpeedSet(int speed) {
            if (speed<0)
            {
                throw new Exception(" the speed cannot less zero");
            }
            Speed = speed;
        }
        public virtual void PowerSet(int power)
        {
            if (power < 0)
            {
                throw new Exception(" the power cannot less zero");
            }
            Power = power;
        }
        public virtual void HeltSet(int helth)
        {
            if (helth < 0&&helth>=100)
            {
                throw new Exception(" the helth cannot less zero or more 100");
            }
            Helth = helth;
        }
    }
}
