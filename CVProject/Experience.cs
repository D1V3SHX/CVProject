using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Experience : IMenuDetails
    {
        private string companyName;
        private string workedFrom;
        private string workedTo;
        private string employementType;
        private string jobTitle;
        private string jobDescription;
        private bool currentJob;

        public Experience(string companyName, string workedFrom, string workedTo, string employementType, string jobTitle, string jobDescription)
        {
            this.CompanyName = companyName;
            this.WorkedFrom = workedFrom;
            this.WorkedTo = workedTo;
            this.EmployementType = employementType;
            this.JobTitle = jobTitle;
            this.JobDescription = jobDescription;
        }

        //overloaded constructor for current job
        public Experience(string companyName, string workedFrom, string employementType, string jobTitle, string jobDescription, bool currentJob)
        {
            this.CompanyName = companyName;
            this.WorkedFrom = workedFrom;
            this.WorkedTo = "Present";
            this.EmployementType = employementType;
            this.JobTitle = jobTitle;
            this.JobDescription = jobDescription;
            this.currentJob = true;
            
        }

        public void displayCompanyNameWithExperience()
        {
            Console.WriteLine(this.CompanyName + " ( " + this.WorkedFrom + "-" + this.WorkedTo + " ) ");
        }

        //display experience menu - overriding interface method
        public void displayMenu()
        {
            Console.WriteLine(this.CompanyName + " ( " + this.WorkedFrom + "-" + this.WorkedTo + " ) ");
        }


        public string getJobDescription()
        {
            return jobDescription;
        }

        public string CompanyName { get => companyName; set => companyName = value; }
        public string WorkedFrom { get => workedFrom; set => workedFrom = value; }
        public string WorkedTo { get => workedTo; set => workedTo = value; }
        public string EmployementType { get => employementType; set => employementType = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
    }
}
