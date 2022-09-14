using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class MainMenu : IMenuDetails
    {
        public string[] menuOptions = { " Experience / Job History", " Education / Training", " Skills", " Technological Skills", " Contact Details" };


        public void displayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------Main Menu----------");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + menuOptions[i]);
            }
            Console.WriteLine("Select an option to continue");
            Console.WriteLine();

            
        }

        //MAIN MENU HANDLING USING DICTIONARY
        public void handlemenu(Person p1)
        {   //Mapping strings to methods
            var MainMenuDictionary = new Dictionary<string, Action>()
            {
                {"Experience", () => handleExperience(p1) },
                {"Education", () => handleEducation(p1) },
                {"Skills", () => handleSkills(p1) },
                {"TechnologicalSkills", () => TechnologicalSkills(p1) },
                {"ContactDetails", () => handleContactDetails(p1) }

            };      
            while (true)
            {
                displayMenu();
                //Console.WriteLine(MainMenuDictionary.Count);
                //checking validity of user input
                var responseAsString = Console.ReadLine();
                int response;
                bool parseSuccess = int.TryParse(responseAsString, out response);
                //validation for invalid input incluidng non integers and for choices not shown
                if ( (response <= MainMenuDictionary.Count) && (response>0) && parseSuccess )
                {
                    MainMenuDictionary[((MainMenuOptionsEnum)response).ToString()]();
                    
                }
                else
                {
                    continue;
                }
                
            }
        }

        private void TechnologicalSkills(Person p1)
        {
            p1.handleTechnologySkillsMenu(p1);
        }

        private void handleContactDetails(Person p1)
        {
            p1.handleContactMenu(p1);
        }

        private void handleEducation(Person p1)
        {
            p1.handleEducationTraining(p1);
        }

        //Handler methods
        private static void handleSkills(Person p1)
        {
            p1.handleSkillsMenu(p1);
        }


        private static void handleExperience(Person p1)
        {
            p1.handleExperienceMenu(p1);
        }

        //Main Menu Options Enum
        enum MainMenuOptionsEnum
        {
            Experience = 1,
            Education = 2,
            Skills = 3,
            TechnologicalSkills = 4,
            ContactDetails = 5,

        }

    }

}
