using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
 public static class Oop
    {
        
        public static void ADDprojects(int type,int projectID,string title,string discription,int days) 
        {
                ProjectManager projectManager = new ProjectManager();
            if (type == 1)
            {
                
                SoftwareProject softwareProject = new SoftwareProject();
                projectManager.AddProject(softwareProject);

                softwareProject.AddTask(title, discription, DateTime.Now.AddDays(days));

            }
            if (type == 2)
            {
                HardwareProject hardwareProject = new HardwareProject ();
                
                projectManager.AddProject(hardwareProject);
            }
        }
        public static void ShowAllProject() 
        {
            ProjectManager projectManager = new ProjectManager();
            projectManager.DisplayAllProjects();
        }
    }
}
