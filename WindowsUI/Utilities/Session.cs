using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace WindowsUI.Utilities
{
    public static class Session
    {
        public static Employee CurrentEmployee { get; set; }
        public static Project CurrentProject { get; set; }

        public static void SetCurrentEmployee(Employee employee)
        {
            CurrentEmployee = employee;
        }
        public static void SetCurrentProject(Project project)
        {
            CurrentProject = project;
        }
    }
}
