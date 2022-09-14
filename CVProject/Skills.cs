using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Skills : IMenuDetails
    {
        public string[] skills;

        public Skills(string[] skills)
        {
            this.skills = skills;
        }

        public void displayMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------Skills-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            for (int i = 0; i < skills.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + skills[i]);
                
            }
           Console.WriteLine();
        }

   


    }
}
