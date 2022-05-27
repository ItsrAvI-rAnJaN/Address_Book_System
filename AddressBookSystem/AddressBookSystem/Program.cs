using System;

namespace AddressBookSystem
{
    public class Program
    {
        // Create Static Main Method 
        static void Main(string[] args)
        {
            // printing Welcome Message
            Console.WriteLine("\t\t\t******* WELCOME TO ADDRESS BOOK SYSTEM PROGRAM ******");

            int Choice;
            do
            {
                // taking output from user to Executed the Program
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Get Contact Present in Address Book ");
                Console.WriteLine("2. Add New Contact to Address Book");
                Console.WriteLine("3. Edit Contact Present in Address Book");
                Console.Write("Enter Your Choice : ");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        // creating Instance/Object of Class AddressBook & setting Parameters value..
                        AddressBook objdetails = new AddressBook("Ravi", "Ranjan", "DLF Phase 4", "Gurugram", "Haryana", 122002, 9319964621, "Ezekie.em@gmail.com");

                        // Calling Method Define in Address Class to Displaying Details.
                        objdetails.DisplayContactDetails();
                        break;
                    case 2:
                        ContactPerson objaddnewcontact = new ContactPerson();
                        objaddnewcontact.AddNewContact();
                        objaddnewcontact.DisplayContactDetails();
                        break;
                    case 3:
                        // creating instance & call the Method to Add New Contact
                        ContactPerson objeditcontact = new ContactPerson();
                        objeditcontact.AddNewContact();
                        objeditcontact.DisplayContactDetails();

                        // for Editing Contact & call the Method of Editing Contact
                        Console.WriteLine("Edit Contact Using first Name ? 1: Y/N");
                        Console.Write("Enter Your Choice : ");
                        string Choice_3 = Console.ReadLine();
                        if (Choice_3 == "Y")
                        {
                            objeditcontact.EditContactDetails();
                            objeditcontact.DisplayContactDetails();
                        }
                        break; 

                    default:
                        Console.WriteLine(" Enter Correct Choice");
                        break;
                }

            }
            while(Choice != 0);

            // To Hold Output Terminal
            Console.ReadKey();


        }
    }
}
