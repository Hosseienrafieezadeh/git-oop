using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
public interface ITask
    {
        string Title { get; set; }
        int Priority { get; set; }
        DateTime DueDate { get; set; }

        void DisplayTaskInfo();
    }
}
