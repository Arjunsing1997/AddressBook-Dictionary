using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Dictionary
{
    class Program
    {

       static Dictionary<string, Person> People = new Dictionary<string, Person>();
        public class Person     //creating a class with get and set method
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

        }
        /// <summary>
        /// Adds the person.
        /// </summary>
        private static void AddPerson()
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



            People.Add(person.City, person);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook-Dictionary");
            Console.WriteLine("Enter Add->To add details\n exit->To exit");
            string command = Console.ReadLine();
            while( command != "exit")
            {
                AddPerson();
            }
            

        }
    }
}
