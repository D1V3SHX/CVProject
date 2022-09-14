using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Education : IMenuDetails
    {
        private string startDate, endDate;
        private  Courses courses;
        private Training training;

        public Education(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }

        public void displayMenu()
        {
            Console.WriteLine("Generic desc of edu");
        }

        public void handlemenu(Person p1)
        {
           
        }
    }
}
