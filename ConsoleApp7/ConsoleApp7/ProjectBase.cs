using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
public  class ProjectBase:IProject
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public List<Task> Tasks { get; set; }

        public ProjectBase()
        {
            Tasks = new List<Task>();
        }

        public virtual void AddTask(string title, string description, DateTime dueDate)
        {
            var task = new Task
            {
                TaskID = Tasks.Count + 1,
                Title = title,
                Description = description,
                DueDate = dueDate
            };
            Tasks.Add(task);
        }

        public virtual void DisplayProjectInfo()
        {
            Console.WriteLine($"Project ID: {ProjectID}, Title: {Title}");
            Console.WriteLine("Tasks:");
            foreach (var task in Tasks)
            {
                task.DisplayTaskInfo();
            }
        }
}
