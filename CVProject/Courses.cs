using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Courses : IMenuDetails
    {
        private string startDate;
        private string endDate;
        private string courseName;
        private string courseType;
        private string[] modules;
        private string[] projects;

        public Courses(string startDate, string endDate,string courseName, string courseType, string[] modules, string[] projects)
        {
            this.EndDate = endDate;
            this.StartDate = startDate;
            this.CourseName = courseName;
            this.CourseType = courseType;
            this.Modules = modules;
            this.Projects = projects;
        }

        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseType { get => courseType; set => courseType = value; }
        public string[] Modules { get => modules; set => modules = value; }
        public string[] Projects { get => projects; set => projects = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }

        public void displayCourseDetails()
        {
            Console.WriteLine();
            Console.WriteLine("------Modules:------");
            for (int i = 0; i < Modules.Length; i++)
            {
                Console.WriteLine(Modules[i]);
            }
            Console.WriteLine();
            Console.WriteLine("------Projects:-------");
            for (int i = 0; i < Projects.Length; i++)
            {
                Console.WriteLine(Projects[i]);
            }
            Console.WriteLine();
        }

        public void displayMenu()
        {
            Console.WriteLine(this.CourseName+ " (" + this.StartDate+ ") ");
        }
    }
}
