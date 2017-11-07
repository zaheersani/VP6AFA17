using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6A
{
    public class PhoneBook2
    {
        private List<Contact> contacts;

        public PhoneBook2()
        {
            contacts = new List<Contact>();
        }

        public void Add(string Name, string Number)
        {
            contacts.Add(new Contact()
            {
                Name = Name,
                Number = Number
            });
        }

        public Contact this[string Number]
        {
            get
            {
                return contacts.Find(x => x.Number == Number);
            }
        }

        public List<Contact> this[string Name, bool name]
        {
            get
            {
                return contacts.FindAll(x => x.Name.ToLower().StartsWith(Name.ToLower()));
            }
        }

        public List<Contact> toList()
        {
            return contacts;
        }
    }

    public class PhoneBook
    {
        private int[] Numbers;
        private string[] Names;
        private int count;

        private List<Contact> contacts;

        public PhoneBook(int size)
        {
            contacts = new List<Contact>(size);
            Contact c = new Contact();
            c.Name = "abc";
            c.Number = "0333";

            this.Numbers = new int[size];
            this.Names = new string[size];
            this.count = 0;
        }

        public void Add(string Name, int Number)
        {
            Names[count] = Name;
            Numbers[count] = Number;
            count++;
        }

        public string this[int number]
        {
            get
            {
                
                for (int i = 0; i < count; i++)
                {
                    if (this.Numbers[i] == number)
                        return this.Names[i];
                }
                return null;
            }
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (this.Names[i] == name)
                        return this.Numbers[i];
                }
                return -1;
            }
        }
    }

    public struct Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            return "Name: " + this.Name + "\nPhoneNumber: " + this.Number;
        }
    }
}
