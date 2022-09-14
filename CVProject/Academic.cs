using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Academic : Education 
    {
        //private Courses courses;
        private Courses courses1;

        //public Academic(string startDate, string endDate, Courses courses) : base(startDate, endDate)
        //{
        //    this.courses = courses;
        //}

        public Academic(string startDate, string endDate, Courses courses1) : base(startDate, endDate)
        {
            this.courses1 = courses1;
        }

        public void displayMenu()
        {
            Console.WriteLine(courses1.CourseName+" ( "+ this.StartDate + ")");
        }
    }
}
