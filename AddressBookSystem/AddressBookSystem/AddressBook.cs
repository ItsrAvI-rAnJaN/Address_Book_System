
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // create class in this Defining Method for Address Book System..
    internal class AddressBook
    {
        // creating String & Int Type  Variable to Store Details
        string First_Name;
        string Last_Name;
        string Address;
        string City;
        string State;
        int Zip_Code;
        long Phone_Number;
        string Email_Address;
        List<AddressBook> AddressList;


        // Defining Paramterized Constructor
        public AddressBook(string First_Name, string Last_Name, String Address, string City, string State, int Zip_Code, long Phone_Number, string Email_Address)
        {

            // set Class level Variables Value from the Constructor
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip_Code = Zip_Code;
            this.Phone_Number = Phone_Number;
            this.Email_Address = Email_Address;
            AddressList = new List<AddressBook>();

        }
        public void AddingContactDetails()
        {
            //Filling the contact details
            Console.WriteLine("Add details one by one");
            Console.Write("Enter First Name : ");
            string First_Name = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            string Last_Name = Console.ReadLine();
            Console.Write("Enter Address : ");
            string Address = Console.ReadLine();
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.Write("Enter State : ");
            string State = Console.ReadLine();
            Console.Write("Enter zip code : ");
            int Zip_Code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone number : ");
            long Phone_Number = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Email id : ");
            string Email_Address = Console.ReadLine();

            //Passing values to the details object
            AddressBook details = new AddressBook(First_Name, Last_Name, Address, City, State, Zip_Code, Phone_Number, Email_Address);

            //Checking if entered details already present or not
            if (AddressList.Contains(details))
            {
                Console.WriteLine("These details already present in Address book");
            }

            //If not add it to the list
            else
            {
                AddressList.Add(details);
            }
        }


        // creating Method/Function to Displaying Details..
        public void DisplayContactDetails()
        {
            foreach(AddressBook d in AddressList)
            {
                // printg Details..
                Console.WriteLine("\nContact Details are :-");
                Console.WriteLine("Name : {0} {1}", First_Name, Last_Name);
                Console.WriteLine("Address : {0}, {1} ({2})", Address, City, State);
                Console.WriteLine("Zip Code : {0}", Zip_Code);
                Console.WriteLine("Ph. Number : {0}", Phone_Number);
                Console.WriteLine("Email Address : {0}", Email_Address);
            }
           
        }
    }
}