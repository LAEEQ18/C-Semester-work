using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book
{
    class DataClass
    {
        private static DataClass shared = null;

        public static DataClass getShared()
        {
            if (shared == null)
            {
                shared = new DataClass();
            }
            return shared;
        }
        private List<Contact> contacts;
        public DataClass()
        {
            contacts = new List<Contact>();
        }

        public void addContact(string name, int age, string email, string phone, string address, bool isMale)
        {
            contacts.Add(new Contact(name, age, email, phone, address, isMale));
        }

        public Contact searchByName(string name)
        {
            Contact c = new Contact();
            foreach (Contact cont in contacts)
            {
                if (cont.name == name)
                {
                    c = cont;
                    break;
                }
            }
            return c;
        }

        public void deleteContact(string name)
        {
            foreach (Contact cont in contacts)
            {
                if (cont.name == name)
                {
                    contacts.Remove(cont);
                    break;
                }
            }
        }

        public bool hasContact(string name)
        {
            bool tr = false;
            foreach (Contact cont in contacts)
            {
                if (cont.name == name)
                {
                    tr = true;
                    break;
                }
            }
            return tr;
        }

        public List<Contact> getContacts(string name)
        {
            var cl = new List<Contact>();
            foreach (Contact cont in contacts)
            {
                if (cont.name == name)
                {
                    cl.Add(cont);
                }
            }
            return cl;
        }

        public List<Contact> getAllContacts()
        {
            return contacts;
        }
    }
}
