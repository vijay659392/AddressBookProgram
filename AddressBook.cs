﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook
    {
        Contact contact = new Contact();

        public void CreatContact()
        {
            contact.FirstName=Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Email = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Contact Details" + "\n" + "First Name" + contact.FirstName + "\n" + "Last Name" + contact.LastName + "\nEmail" + contact.Email +
                "\nCity"+contact.City+"\nPhone Number"+contact.PhoneNumber+"\nAddress"+contact.Address+"\nZip Code"+contact.Zip+"\nState"+contact.State);
        }
    }
}
