using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  public  class Car
    {
        private int _model { get; set; }

        public Car(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Model
        {
            get { return _model; }
            set
            {
                if (value<2010)
                {
                    throw new Exception("this car go to sell out of date");
                } 
            }
        }
        public int Count { get;private set; }

        public virtual void SetCount(int count)
        {
            if (count<0)
            {
                throw new Exception("the car count can not less zero");
            }
            Count = count;
        }
    }
}
