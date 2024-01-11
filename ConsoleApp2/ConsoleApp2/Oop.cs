using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Oop
    {
       private static List<Employee> _employees = new();
        private static List<Department> _departments = new();
        private static List<Manager> _managers = new();
      

        public static void AddDepartment(string name) 
        {
            var depname = new Department(name);
            _departments.Add(depname);
        }
        public static void AddEmployes(int employesID,int salary ,int type) 
        {
            if (type == 1)
            {
                var emp = new Employee();
                emp.EmployeeID = employesID;
                emp.Salary = salary;
                _employees.Add(emp);
            }
            if (type==2)
            {
                var mang = new Manager();
                mang.EmployeeID = employesID;
                mang.Salary = salary;

                _employees.Add(mang);
            }
            
        }

        public static void AddDepToManger(int ID,string name) 
        {
            var mangname = _employees.Find(_ => _.EmployeeID == ID)as Manager;
            if (mangname is null)
            {
                throw new Exception(" not foud");
            }
            var depname = _departments.Find(_=>_.Name==name);

            if (depname is null)
            {
                throw new Exception(" not found");
            }



            mangname.Departmentt = depname.Name;
            _employees.Add(mangname);
          
        }
        public static void ShowEmp() 
        {
            Console.WriteLine("***********************");
            foreach (var item in _employees)
            {
                item.PeintDetalis();
                
            }
            Console.WriteLine("***********************");
        }
    }

}
