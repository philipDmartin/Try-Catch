using System;
using System.Collections.Generic;

namespace addressbook
{
    public class AddressBook
    {
        private Dictionary<string, Contact> _addressList = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            _addressList.Add(contact.Email);
        }

        public Contact GetByEmail(string email)
        {
            return _addressList.Email;
        }
    }
}
