using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Person
    {
        private string fname;
        private string lname;
        private int age;
        private string introdction;
        //private Experience[] experience;
        private List<Experience> experience;
        MainMenu mainmenu = new MainMenu();
        private Skills skills;

        private Courses[] courses;
        private Training[] trainings;

        //private EducationAndTraining[] educationAndTraining;

        //private ContactDetails[] contactDetails;
        //private Education[] educationDetails;
       // private Education[] academics;
        //private Education[] trainings;
        

        //public Experience[] Experience { get => Experience1; set => Experience1 = value; }
        public List<Experience> Experience{ get => experience; set => experience = value; }

        public Person(string fName, string lName, int age, string introdction, List<Experience> experience,  Skills skills, Courses[] courses, Training[] trainings)
        {

            this.fname = fName;
            this.lname = lName;
            this.age = age;
            this.introdction = introdction;
            this.Experience = experience;
            this.courses = courses;
            this.skills = skills;
            this.trainings = trainings;

        }
       
        public void setInroduction(string intro)
        {
            this.introdction = intro;
        }
        public string getIntroduction()
        {
            return introdction;
        }

//INTRODUCTION HANDLING
        public void displayIntroduction()

        {
            Console.WriteLine();
            string fname = (this.fname).ToUpper();
            string lname = (this.lname).ToUpper();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(fname + " " + lname);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(getIntroduction());
            Console.WriteLine();
        }

//EXPERIENCE HANDLING
        public void displayExperience()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----Experience / Job History-----");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Experience.Count; i++)
            {
                Console.Write(i + 1 + ". ");
                this.Experience[i].displayMenu();
            }
            Console.WriteLine("0. Go Back");
            Console.WriteLine("Select your choice");
            Console.WriteLine();
            //int response = Convert.ToInt32(Console.ReadLine());
            //getExperienceDetails(response);
        }


        public void getExperienceDetails(int index)
        {
            string str = Experience[index - 1].getJobDescription();
            Console.WriteLine(str);
        }



        //HandleMenu Method

        public void handleExperienceMenu(Person p1)
        {
            Boolean goBack = false;
            //int choice;



            while (!goBack)
            {
                p1.displayExperience();
                try
                {
                    int response = Convert.ToInt32(Console.ReadLine());
                    if((response <= p1.experience.Count) && (response > 0))
                    {
                        p1.getExperienceDetails(response);
                    }
                    else if (response == 0)
                    {
                        //Console.WriteLine("aa");
                        goBack = true;
                    }
                }
                catch (System.FormatException)
                {
                    p1.displayExperience();
                }              

            }

        }


        
        //EDUCATION AND TRAINING HANDLING


        public void displayCourses()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----Education / Training-----");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                this.courses[i].displayMenu();
            }
            Console.WriteLine("0. Go Back");
            Console.WriteLine("Select your choice");
            Console.WriteLine();
        }

        public void getCourseDetails(int index)
        {
            courses[index-1].displayCourseDetails();

        }
        //handler method
        public void handleEducationTraining(Person p1)
        {
            Boolean goBack = false;
            int choice;

            while (!goBack)
            {
                p1.displayCourses();
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    goBack = true;
                }
                else
                {
                    p1.getCourseDetails(choice);
                    //Console.WriteLine("aaa");
                }
                //Console.WriteLine(choice);
            }
        }

 //SKILLS HANDLING

        public void handleSkillsMenu(Person p1)
        {
           
            p1.displaySkills();
            MainMenu mainmenu = new MainMenu();
            mainmenu.handlemenu(p1);
        }
        public void displaySkills()
        {
            skills.displayMenu();
        }


        //ADD EXPERIENCE;
        public void AddExperience(Experience e)
        {
            experience.Add(e);
        }

        //public void isValid()
        //{

        //}
    }
}


//public Person(string fName, string lName, int age, string introdction, Experience[] experience, Education[] academics, Skills skills)
//{

//    this.fname = fName;
//    this.lname = lName;
//    this.age = age;
//    this.introdction = introdction;
//    this.Experience = experience;
//    //this.academics = academics;
//    this.skills = skills;
//    //this.trainings = trainings;

//}

//public Person(string fName, string lName, int age, string introdction, Experience[] experience, Education[] academics, Education[] trainings, Skills skills)
//{

//    this.fname = fName;
//    this.lname = lName;
//    this.age = age;
//    this.introdction = introdction;
//    this.Experience = experience;
//    //this.academics = academics;
//    this.skills = skills;
//    //this.trainings = trainings;

//}

//public void handleExperienceMenu(Person p1)
//{
//    Boolean goBack = false;
//    //int choice;



//    while (!goBack)
//    {
//        p1.displayExperience();

//        var responseAsString = Console.ReadLine();
//        int response;
//        bool parseSuccess = int.TryParse(responseAsString, out response);
//        //Console.WriteLine(responseAsString);

//        // choice = Convert.ToInt32(Console.ReadLine());

//        if ((response <= p1.experience.Count) && (response > 0) && parseSuccess)
//        {
//            p1.getExperienceDetails(response);

//        }
//        else if (response == 0)
//        {
//            //Console.WriteLine("aa");
//            goBack = true;
//        }
//        else
//        {
//            //Console.WriteLine("aa");
//            p1.displayExperience();

//        }

//        //if (choice == 0)
//        //{
//        //    goBack = true;
//        //}
//        //else
//        //{
//        //    p1.getExperienceDetails(choice);
//        //    //Console.WriteLine("aaa");
//        //}
//        //Console.WriteLine(choice);
//    }

//}

//var responseAsString = Console.ReadLine();
//int response;
//bool parseSuccess = int.TryParse(responseAsString, out response);

//        if ((response <= MainMenuDictionary.Count) && (response>0) && parseSuccess )
//        {
//            MainMenuDictionary[((MainMenuOptionsEnum)response).ToString()] ();

//        }
//        else
//        {
//            continue;
//        }
