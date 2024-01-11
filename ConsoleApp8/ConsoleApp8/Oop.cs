using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
  public static  class Oop
    {
        private static List<ITask> _tasks = new();
        public static void ADDTasks(int type ,string title,int Priority, int day) 
        {
            if (type==1)
            {
                var normal = new NormalTask();
                normal.Title = title;
                normal.Priority = Priority;
                normal.DueDate = DateTime.Now.AddDays(day);
                _tasks.Add(normal);
            }
            if (type == 2) 
            {
                var HighPriority = new HighPriorityTask();
                HighPriority.Title = title;
                HighPriority.Priority = Priority;
                HighPriority.DueDate = DateTime.Now.AddDays(day);
                _tasks.Add(HighPriority);
            }
        }
        public static void ShowTasks ()
        {
            Console.WriteLine("**************************All Tasks**************************");
            foreach (var task in _tasks)
            {
                task.DisplayTaskInfo();
            }
        }
    }
}
