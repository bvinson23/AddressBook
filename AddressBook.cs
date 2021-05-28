using System;

using System.Collections.Generic;

namespace AddressBook
{
    class AddressBook
    {
        public Dictionary<string, Contact> Contacts { get; set; }
        
        public AddressBook()
        {
            Contacts = new Dictionary<string, Contact>();
        }
        public void AddContact(Contact contact)
        {
            try
            {
            Contacts.Add(contact.Email, contact);
            }
            catch
            {
                Console.WriteLine($"{contact.FullName()} already in address book.");
            }
        }
        public Contact GetByEmail(string email)
        {
            Contacts.TryGetValue(email, out Contact Email);
            return Email;
        }
    }
}