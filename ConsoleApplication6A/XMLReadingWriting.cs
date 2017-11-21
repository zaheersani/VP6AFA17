using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication6A
{
    class XMLReadingWriting
    {
        static void Main()
        {
            Employee empObj = new Employee();
            empObj.DateOfBirth = new DateTime(1990, 12, 12);
            empObj.Address = new EmployeeAddress()
            {
                HouseNo = 123,
                PostCode = "XL2345"
            };
            //empObj.Car
            //EmployeeCar[] carArr = new EmployeeCar[] { new EmployeeCar() { Make = "", Model = "" } };
            empObj.Car = new EmployeeCar[]
            {
                new EmployeeCar() {
                Make = "Volvo",
                Model = "XSeries"
                }
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            TextWriter writer = new StreamWriter("emp.xml");

            serializer.Serialize(writer, empObj);
            writer.Close();
        }
    }
}
