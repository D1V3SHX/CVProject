using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    internal class Program
    {
        static void Main(string[] args)
        {



   //USER DATA HARDCODED
            string intro1 = "Aiming to reduce global warming throgh sustainable energy production and consumption. " +
                             "Planning to reduce the risk of human extinction by making life multi-planetary and setting up a" +
                             " human colony on Mars";
            string intro2 = "Genius, Billionaire, Philanthropist";

           // Experience[] experience = new Experience[2];

            List<Experience> experience = new List<Experience>();
            experience.Add(new Experience("Tesla Motors", "2020", "2021", "fulltime", "CEO", "Generic description of a what a CEO does"));
            experience.Add(new Experience("Ceridian", "2022",  "internship", "intern", "Technology Training: " +
                                           "Ramp up on following stack trainin[C#, Front End, SQL, Automation]", true));
            experience.Add(new Experience("SpaceX", "2020", "2022", "fulltime", "CEO", "Plans to reduce space transporstation cost"));



            //experience[0] = new Experience("Tesla", "2020", "2021", "fulltime", "CEO", "Generic description of a what a CEO does");
            // experience[1] = new Experience("Ceridian", "2022", "2022", "internship", "intern", "Technology Training: " +
            // "Ramp up on following stack trainin[C#, Front End, SQL, Automation]");

            string[] modules1 = { "Programming", "Computational Maths", "Database Design", "Computer Architecture" };
            string[] projects1 = { "Prison Database" };

            string[] modules2 = { "OS", "OOT", "GUI", "web" };
            string[] projects2 = { "Prison Database", "Restaurant Website", "Attendance Management System" };

            //EDUCATION AND TRAINING
            Courses[] courses = new Courses[3];
            courses[0] = new Courses("2020", "2021", "Computer Science", "full-time", modules1, projects1,false);
            courses[1] = new Courses("2021", "2022", "Computer Science", "full-time", modules2, projects2,false);
            courses[2] = new Courses("2021", "2022", "Git Training", "Learned how to use Git Bash and Github", true);

            //TRAININGS            //Training[] trainings = new Training[2];
            //trainings[0] = new Training("2019", "2020", "Git Training", "Learned how to use git");
            //trainings[1] = new Training("2019", "2020", "Clean Code", "Learned how to use clean code ");


            //SKILLS
            string[] skillsArray = { "Honesty", "Discipline", "Punctual"};
            Skills skills = new Skills(skillsArray);
            
            //TECHNOLOGICAL SKILLS
            string[] TechnoskillsArray = { "JAVA", "C#", "Rocket Engineering" };
            TechnologySkills technoskills = new TechnologySkills(TechnoskillsArray);

            //CONTACT DETAILS
            string[] numbers = {"8938483483", "343434343" };
            string[] emails = {"elon.musk@gmail.com", "elon.musk@ceridian.com" };
            ContactDetails[] contactDetails = new ContactDetails[1];
            contactDetails[0] = new ContactDetails(numbers, emails);




            //CREATING A USER
            Person user1 = new Person("Elon", "Musk", 51, intro1, experience,  skills, courses, contactDetails, technoskills);
            //Person p2 = new Person("Tony", "Stark", 48, intro2, experience,  skills, courses,  contactDetails, technoskills);

            //Dynnamically adding an experience
            user1.AddExperience(new Experience("Solar City", "2020", "2021", "fulltime", "Chairman", "Electric Vehicles is the way to go"));


            //END OF HARD CODED VALUES
            //*************************************************************************************************************************************************************

                       //FIXED INTRODUCTION DISPLAY
                         user1.displayIntroduction();


                        //CALLING MAIN MENU 
                        MainMenu mainmenu = new MainMenu();
                        mainmenu.handlemenu(user1);
            

                        //PREVENT CONSOLE FROM CLOSING
                        Console.ReadLine();
        }

    }
}