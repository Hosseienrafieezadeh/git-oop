using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public void DisplayTaskInfo()
        {
            Console.WriteLine($"Task ID: {TaskID}, Title: {Title}, Due Date: {DueDate}, Completed: {IsCompleted}");
        }
    }
}
