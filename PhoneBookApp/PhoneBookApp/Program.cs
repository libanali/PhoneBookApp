using System;

namespace PhoneBookApp
{

    class  Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Console.WriteLine("Select Operation");

            Console.WriteLine("1 Add Contact");

            Console.WriteLine("2 Display contact by number");

            Console.WriteLine("3 View all contacts");

            Console.WriteLine("4 Search for contacts for a given name");

            Console.WriteLine("Press X to exit");

            var userInput = Console.ReadLine();



            var phoneBook = new Phonebook();




            while(true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();

                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;

                    case "2":
                        Console.WriteLine("Contact number to search");
                        var searchnumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchnumber);


                        break;


                    case "3":

                        phoneBook.DisplayAllContact();
                        break;


                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);

                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Select valid operation");

                        break;


                }

                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();

            }

            
        }
    }
  


    
}
