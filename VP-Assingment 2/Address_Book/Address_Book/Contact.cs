using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book
{
    class Contact
    {
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public bool isMale { get; set; }

        public Contact(string name, int age, string email, string phone, string address, bool isMale)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.isMale = isMale;
        }

        public Contact()
        {

        }
    }
}
