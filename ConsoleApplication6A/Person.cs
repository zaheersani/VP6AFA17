using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6A
{
    public class Person
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
    public class Student : Person
    {
        public RegNo RegNo { get; set; }
        public byte Age { get; set; }
        public DateTime DOB { get; set; }

        public Student()
            : base() { }

        public Student(string FirstName, string LastName, RegNo RegNo, byte Age)
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

    public enum ProgramCIIT { BCS, BSE, BTN, BEL }
    public enum Batch { FA, SP }
    public class RegNo
    {
        public Batch Batch { get; set; }
        public ushort Year { get; set; }
        public ProgramCIIT Program { get; set; }
        public ushort RollNo { get; set; }

        public RegNo(Batch batch, ushort year, ProgramCIIT program, ushort RollNo)
        {
            this.Batch = batch;
            this.Year = year;
            this.Program = program;
            this.RollNo = RollNo;
        }

    }
}
