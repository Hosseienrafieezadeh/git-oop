using System;

namespace ConsoleApp2
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
        static void Run()
        {
            var option = AddInt("1:add employee\n2:add department\n3:add manger to dep \n4:show emp");
            switch (option)
            {
                case 1:
                    {
                        var empId = AddInt("write employeeID");
                        var empSal = AddInt("write emp salary");
                        var type = AddInt("1_employees 2_manger");
                        Oop.AddEmployes(empId, empSal, type);
                        break;
                    }
                case 2:
                    {
                        var depName = AddString("write name ");
                        Oop.AddDepartment(depName);
                        break;
                    }
                case 3:
                    {
                        var empID = AddInt("write manger id");
                        var depName = AddString("write name dep ");
                        Oop.AddDepToManger(empID, depName);
                        break;
                    }
                case 4: 
                    {
                        Oop.ShowEmp();   
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
