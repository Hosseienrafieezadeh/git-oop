using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
   public class TaskBase:ITask
    {
        public string Title { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }

        public virtual void DisplayTaskInfo()
        {
            Console.WriteLine($"Title: {Title}, Priority: {Priority}, Due Date: {DueDate}");
        }
    }
}
