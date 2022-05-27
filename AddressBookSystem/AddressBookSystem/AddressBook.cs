
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // create class in this Defining Method for Address Book System..
    public class AddressBook
    {
        // creating String & Int Type  Variable to Store Details
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int Zip_Code;
        public long Phone_Number;
        public string Email_Address;


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
          

        }
       
        // creating Method/Function to Displaying Details..
        public void DisplayContactDetails()
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