using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Training : IMenuDetails
    {
        private string trainingTitle;
        private string trainingDescription;
        private string startDate;
        private string endDate;


        public Training(string startDate, string endDate, string trainingTitle, string trainingDescription)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TrainingTitle = trainingTitle;
            this.TrainingDescription = trainingDescription;
        }

        public string TrainingTitle { get => trainingTitle; set => trainingTitle = value; }
        public string TrainingDescription { get => trainingDescription; set => trainingDescription = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }

        public void displayMenu()
        {
            Console.WriteLine(this.TrainingTitle);
        }

        //public void displayMenu()
        //{

        //}
    }

}
