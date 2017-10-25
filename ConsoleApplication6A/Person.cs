using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6A
{
    public interface IEqualGeneric<T>
    {
        bool IsEqual(T obj);
    }

    public interface IStudentInfo
    {
        string DisplayInformation(Student sobj);
    }

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public abstract void DisplayInfo();
    }

    public class Student : Person, IStudentInfo, IEqualGeneric<Student>
    {
        public RegNo RegNo { get; set; }
        public byte Age { get; set; }
        public DateTime DOB { get; set; }

        public bool IsEqual(Student sObj)
        {
            if (this.FirstName == sObj.FirstName)
                return true;
            return false;
        }

        public string DisplayInformation(Student sObj)
        {
            return null;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }

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

    public class RegNo : IEqualGeneric<RegNo>
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

        public bool IsEqual(RegNo obj)
        {
            if (this.Batch == obj.Batch && this.Year == obj.Year)
                return true;
            return false;
        }

        public static bool operator ==(RegNo rObj1, RegNo rObj2)
        {
            return rObj1.IsEqual(rObj2);
        }

        public static bool operator !=(RegNo rObj1, RegNo rObj2)
        {
            return !rObj1.IsEqual(rObj2);
        }

        public override string ToString()
        {
            return this.Batch.ToString() + this.Year % 2000 + "-" + this.Program.ToString() + "-" + this.RollNo;
        }
    }

    public class Box
    {
        public double Length { get; set; }   // Length of a box
        public double Breadth { get; set; }  // Breadth of a box
        public double Height { get; set; }  // Hei ght of a box
        
        public double getVolume()
        {
            return this.Length * this.Breadth * this.Height;
        }
        

        public static Box operator +(Box b1, Box b2)
        {
            Box b = new Box();
            b.Length = b1.Length + b2.Length;
            b.Breadth = b1.Breadth + b2.Breadth;
            b.Height = b1.Height + b2.Height;
            return b;
        }

        //TODO: Overload <, >, >=, <=, - operators

    }
}
