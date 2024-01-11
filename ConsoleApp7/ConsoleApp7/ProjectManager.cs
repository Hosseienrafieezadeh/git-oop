using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public  class ProjectManager
    {
        private  List<IProject> Projects { get; set; }

        public  ProjectManager()
        {
            Projects = new List<IProject>();
        }

        public  void AddProject(IProject project)
        {
            Projects.Add(project);
        }

        public  void DisplayAllProjects()
        {
            Console.WriteLine("All Projects:");
            foreach (var project in Projects)
            {
                project.DisplayProjectInfo();
            }
        }
    }
}
