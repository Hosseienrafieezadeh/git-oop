using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception exception)
                {
                    ShowError(exception.Message);
                }
            }

            
        }
        static void Run() {
            var option = AddInt("1:add character\n2:Attck\n3:show list" );
            switch (option)
            {
                case 1: {
                        var name = AddString("write name");
                        var status = Status.life;
                        var type = AddInt("1_hero - 2_enemy - 3_Alive_cr");
                        var speed = AddInt("add speed");
                        var power = AddInt("add power");
                        var helth = AddInt("add helth");
                        Game.AddCharector(name,speed,power,type,helth,status);
                        break; 
                    }
                case 2:
                    {
                        var nameattack = AddString("write attack name");
                        var damagename = AddString("write damage name");
                        Game.Damage(nameattack,damagename);
                        break;
                    }
                case 3: 
                    {
                        Console.WriteLine("**********************************");
                        foreach (var charecter in Game.GetCharecters())
                        {
                            Console.WriteLine($"charerctor name:{charecter.Name} -cahrector helth: {charecter.Helth} -status: {charecter.Status}");
                        }
                        Console.WriteLine("***********************************");
                        break;
                    }
                default:
                    break;
            }
        }
        public static int AddInt(string messege)
        {
            int getIntegerValue;
            bool result;
            do
            {
                Console.WriteLine(messege);
                result = int.TryParse(Console.ReadLine(), out getIntegerValue);
            } while (!result);
            return getIntegerValue;
        }
        static void ShowError(string error)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(error);
            Console.WriteLine("-------------------");
        }
        public static string AddString(string messege)
        {
            string? result;
            do
            {
                Console.WriteLine(messege);
                result = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(result));
            return result;
        }
    }
}
