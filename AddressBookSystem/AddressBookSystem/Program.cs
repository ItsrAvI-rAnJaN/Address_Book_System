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

            // creating Instance/Object of Class AddressBook & setting Parameters value..
            AddressBook objdetails = new AddressBook("Ravi", "Ranjan", "DLF Phase 4", "Gurugram", "Haryana", 122002, 9319964621, "Ezekie.em@gmail.com");

            // Calling Method Define in Address Class to Displaying Details.
            objdetails.DisplayContactDetails();

            // To Hold Output Terminal
            Console.ReadKey();
        }
    }
}







