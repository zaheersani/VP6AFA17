using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6A
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }


    }
    class Student : Person
    {
        public string RegNo { get; set; }
        public byte Age { get; set; }
        public DateTime DOB { get; set; }

        public Student()
            : base() { }

        public Student(string FirstName, string LastName, string RegNo, byte Age)
            : base(FirstName, LastName)
        {
            this.RegNo = RegNo;
            this.Age = Age;
        }

        public override string ToString()
        {
            string name = "Name: " + this.FirstName + " " + this.LastName;
            return name + "\n" + "RegNo: " + this.RegNo + "\n" + "Age: " + this.Age + " years";
        }
    }

}
