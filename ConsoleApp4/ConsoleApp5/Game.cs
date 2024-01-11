using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public static  class Game
    {
        private static List<Charecter> _charecters = new();
        public static void AddCharector(string name,int speed,int power, int type,int helth,Status status) 
        {
            if (type == 1) 
            {

                var heros = new Hero(name);
                heros.Status = Status.life;
                heros.PowerSet(power);
                heros.HeltSet(helth);
                heros.SpeedSet(speed);
                _charecters.Add(heros);
            }
            if (type == 2)
            {
                var enemy = new Enemy(name);
                enemy.Status = Status.life;
                enemy.PowerSet(power);
                enemy.HeltSet(helth);
                enemy.SpeedSet(speed);
                _charecters.Add(enemy);
            }
            if (type == 3)
            {
                var Alive = new Alive_cr(name);
                Alive.Status = Status.life;
                Alive.SpeedSet(speed);
                Alive.HeltSet(helth);
                Alive.SpeedSet(power);
                _charecters.Add(Alive);
            }
            
        }
        public static int Damage(string name,string name2) 
        {
            var attack = _charecters.Find(_ => _.Name == name);
            if(attack is null) 
            {
                throw new Exception("not found");
            }
            var damge = _charecters.Find(_ => _.Name == name2);
            if (damge is null) 
            {
                throw new Exception("not found");
            }
            var power = attack.Power;
            var mordan = damge.Helth;
            var finish = mordan - power;
            if (finish <=0) 
            {
                _charecters.Remove(damge);
                damge.Status = Status.deead;
                
            }
            damge.HeltSet(finish);
            
            
            return finish;
        }
        public static List<Charecter> GetCharecters() 
        {
            return _charecters;
        }
    }
}
