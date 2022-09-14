using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class ContactDetails : IMenuDetails
    {
        private string[] numbers;
        private string[] emails;

        public ContactDetails(string[] numbers, string[] emails)
        {
            this.numbers = numbers;
            this.emails = emails;
        }

        public void displayMenu()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------Contact Details-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("Phone Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Email Addresses: ");
            for (int i=0;i<emails.Length;i++)
            {
                Console.WriteLine(emails[i]);
            }
 



        }
    }
}
