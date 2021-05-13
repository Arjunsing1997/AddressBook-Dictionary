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

            bool result = NoDublicates(person.FirstName, person.LastName, person.Address, person.City, person.PhoneNumber);
            if(!result)
                People.Add(person.FirstName, person);


            
        }
        private static void DIsplayPeople()
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
        public static void EditRecords()
        {
            Console.WriteLine("Enter first name:");
            string fname = Console.ReadLine();

            foreach (KeyValuePair<string, Person> item in People) //Value  present or not
            {
                if (item.Value.FirstName.Equals(fname))
                {
                    Person person = People[item.Value.FirstName];
                    Console.WriteLine(person);  //Print person
                    int choice = 0;
                    while (choice != 7)  // k==0 to edite contact
                    {
                        Console.WriteLine("What Do You Want to edit Contact Details \n"
                                + "1. Address\n"
                                + "2. city\n"
                                + "3. State\n"
                                + "4. Zip Code\n"
                                + "5. Phone\n"
                                + "6. Email\n"
                                + "7. Exit\n");

                        choice = Convert.ToInt32(Console.ReadLine());  //convert string and store choice
                        switch (choice)  //case 
                        {
                            case 1:
                                Console.Write("Enter new Address:-  ");  //Take input user
                                String address = Console.ReadLine();   //store address veriable
                                item.Value.Address = address;  //store class of person address data
                                break;
                            case 2:
                                Console.Write("Enter new City:- "); //Take input user
                                String city = Console.ReadLine();  //store city veriable
                                item.Value.City = city;                 //store class of person city data
                                break;
                            case 3:
                                Console.Write("Enter new State:- "); //Take input user
                                String state = Console.ReadLine();   //store state veriable
                                item.Value.State = state;               //store class of person state data
                                break;
                            case 5:
                                Console.Write("Enter new Phone:- "); //Take input user
                                String phone = Console.ReadLine();   //store phone veriable
                                item.Value.PhoneNumber = phone;                 //store class of person phone data
                                break;
                            case 4:
                                Console.Write("Enter new Zip Code:- "); //Take input user
                                String zip = Console.ReadLine();        //store zip veriable
                                person.Zip = zip;                       //store class of person zip data
                                break;
                            case 6:
                                Console.Write("Enter new Email:- "); //Take input user
                                String email = Console.ReadLine();         //store email veriable
                                item.Value.Email = email;                       //store class of person Email data
                                break;
                            case 7:
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        foreach (KeyValuePair<string, Person> t in People) //automate the reading  t of person of class
                        {
                            Console.WriteLine(t);//print list
                        }
                    }
                }
            }
        }

        public static void RemovePerson()
        {
            
            if (People.Count.Equals(0))  //cheking whether list is empty
            {
                Console.WriteLine("List is Empty!!!!! \n Enter any Key to Continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the first name of the person you would like to remove.");
                string firstName = Console.ReadLine();
                if (!People.ContainsKey(firstName)) //this condition describes that there are no match found
                {
                    Console.WriteLine("That person could not be found. Press any key to continue");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    foreach (KeyValuePair<string, Person> item in People)  //Iterating
                    {
                        if (item.Value.FirstName == firstName) //comapring name with the first name of list
                        {
                            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
                            PrintPerson(item.Value);

                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                People.Remove(item.Value.FirstName);   //removing data from list
                                Console.WriteLine("\nPerson removed. Press any key to continue.");
                                Console.ReadKey();
                                break;
                            }
                        }

                    }
                } 
            }
        }

        //public static int Unique(string firstname)
        //{
        //    if(People.ContainsKey(firstname))
        //    {
        //        Console.WriteLine("Name Already Existed....\n Enter a Unique Name please........");
        //        Console.ReadLine();
        //        return 0;
        //    }
        //    else
        //    {
        //        return 1;
        //    }

        //}

        public static bool NoDublicates(string first,string Last, string Address, string city, string phoneNumber)
        {
            bool result = People.Any(x => (x.Value.FirstName == first)||(x.Value.LastName == Last) || (x.Value.Address == Address) || (x.Value.PhoneNumber == phoneNumber));
            if(result)
            {
                Console.WriteLine("User Already Existed\nEnter Any key to Continue...");
                Console.ReadLine();
                return result;
            }
            else
            {
                return result;
            }
        }
        
        public static void SearchByCityState()
        {
            if(People.Count > 0)
            {
                Console.WriteLine("Enter your Choice...\n1)By City\n2)By State");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    Console.WriteLine("Enter your City....");
                    string city = Console.ReadLine();
                    Console.WriteLine("First Name\tLast Name\t City");
                    foreach (KeyValuePair<string, Person> item in People)
                    {
                        //bool searchedCity = People.Any(s => (s.Value.City == city));
                        if(item.Value.City == city)
                        {
                            Console.WriteLine(item.Value.FirstName + "\t" + item.Value.LastName + "\t" + item.Value.City);
                            
                        }
                    } 
                }
                else if( choice == 2)
                {
                    Console.WriteLine("Enter your State....");
                    string state = Console.ReadLine();
                    Console.WriteLine("First Name\tLast Name\t State");
                    foreach (KeyValuePair<string, Person> item in People)
                    {
                       // bool searchedState = People.Any(s => (s.Value.State == state));
                        if (item.Value.State == state)
                        {
                            Console.WriteLine(item.Value.FirstName +"\t\t"+item.Value.LastName+"\t\t"+item.Value.State);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    SearchByCityState();
                }
            }
            else
            {
                Console.WriteLine("There are no Details Available....");
                Console.ReadLine();
            }
            Console.WriteLine("--------------------------------");
            Console.ReadLine();
        }

        public static void GetDetailsByCityState()
        {
            if(People.Count > 0)
            {
                Console.WriteLine("Entre a City or State to search persons Details...");
                string cityState = Console.ReadLine();
                foreach (KeyValuePair<string, Person> item in People)
                {
                    //bool result = People.Any(x => (x.Value.City == cityState));
                    //bool result2 = People.Any(x => (x.Value.State == cityState));

                    if (item.Value.City == cityState)
                    {
                        Console.WriteLine("First Name\tLast Name\t City");
                        //foreach (KeyValuePair<string, Person> item in People)
                        Console.WriteLine(item.Value.FirstName + "\t" + item.Value.LastName + "\t" + item.Value.City);
                       
                    }
                    if (item.Value.State == cityState)
                    {
                        Console.WriteLine("First Name\tLast Name\t State");
                        //foreach (KeyValuePair<string, Person> item in People)
                        Console.WriteLine(item.Value.FirstName + "\t" + item.Value.LastName + "\t" + item.Value.State);
                        
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Address book is EMPTY!!!!!");
            }
            Console.ReadLine();
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook-Dictionary");

            string command = " ";
            while( command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Enter Commands\nAdd\nEdit\nDisplay\nRemove\nSearch\nsearch2\nexit");
                Console.WriteLine("--------------------");
                command = Console.ReadLine();

                switch(command.ToLower())
                {
                    case "add":
                        AddPerson();
                        break;

                    case "edit":
                        EditRecords();
                        break;

                    case "display":
                        DIsplayPeople();
                        break;

                    case "exit":
                        Console.WriteLine("Exiting....");
                        break;

                    case "remove":
                        RemovePerson();
                        break;

                    case "search":
                        SearchByCityState();
                        break;

                    case "search2":
                        GetDetailsByCityState();
                        break;

                    default:
                        Console.WriteLine("Invalid Command");
                        break;
                }
            }
        }
    }
}
