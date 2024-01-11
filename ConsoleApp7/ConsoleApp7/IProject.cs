using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public interface IProject
    {
        void AddTask(string title, string description, DateTime dueDate);
        void DisplayProjectInfo();
    }
}
