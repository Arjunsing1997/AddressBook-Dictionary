using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Dictionary
{
    public class Program
    {

       static Dictionary<string, Person> People = new Dictionary<string, Person>();
        
        /// <summary>
        /// Adds the person.
        /// </summary>
        public static bool AddPerson()
        {
            try
            {
                Person person = new Person();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Address : ");
                person.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                person.City = Console.ReadLine();

                Console.Write("Enter State : ");
                person.State = Console.ReadLine();

                Console.Write("Enter ZIP : ");
                person.Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email : ");
                person.Email = Console.ReadLine();


                People.Add(person.FirstName, person);

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }


            
        }
        public static void DIsplayPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (KeyValuePair<string, Person> person in People)
            {
                PrintPerson(person.Value);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("Satet: " + person.State);
            Console.WriteLine("ZIP: " + person.Zip);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email :" + person.Email);

            Console.WriteLine("-------------------------------------------");
        }
       

        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook-Dictionary");

            string command = " ";
            while( command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Enter Commands\nAdd\nexit");
                Console.WriteLine("--------------------");
                command = Console.ReadLine();

                switch(command.ToLower())
                {
                    case "add":
                        AddPerson();
                        break;

                    default:
                        Console.WriteLine("Invalid Command");
                        break;
                }
            }
        }
    }
}
