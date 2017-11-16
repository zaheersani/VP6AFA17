using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6A
{
    class LINQExamples
    {
        static void Main()
        {
            // var, IEnumerable, List, Sum, Average, Count, Orderby, select new, classes
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] names = { "Albert", "Burke", "Connor", "David",
                   "Everett", "Frank", "George", "Harris"};

            List<Student> sList = new List<Student>();
            sList.Add(new Student()
            {
                FirstName = "Ahmed",
                LastName = "Jahanzaib",
                RegNo = new RegNo(Batch.FA, 2012, ProgramCIIT.BCS, 12),
                DOB = new DateTime(1993, 12, 4)
            });
            sList.Add(new Student()
            {
                FirstName = "Zafar",
                LastName = "Ali",
                RegNo = new RegNo(Batch.FA, 2012, ProgramCIIT.BCS, 13),
                DOB = new DateTime(1993, 1, 4)
            });
            sList.Add(new Student()
            {
                FirstName = "Zeeshan",
                LastName = "Ali",
                RegNo = new RegNo(Batch.FA, 2012, ProgramCIIT.BSE, 34),
                DOB = new DateTime(1992, 12, 4)
            });

            var r = from s in sList
                    where s.RegNo.Batch == Batch.FA
                          && s.LastName.StartsWith("A")
                          && s.RegNo.Program == ProgramCIIT.BCS
                    select new
                    {
                        FName = s.FirstName,
                        LName = s.LastName,
                        DatOfBirth = s.DOB.ToString("MM-dd-yyyy")
                    };
            
            //foreach (var item in r)
            //{
            //    Console.WriteLine(item.DatOfBirth);
            //}

            var result = sList.Where(x => x.RegNo.Program == ProgramCIIT.BCS);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //IEnumerable<string> result = (from n in names
            //                              where n.Length > 5 && n.StartsWith("A")
            //                              orderby n descending
            //                              select n).ToList();

            //foreach (string n in result)
            //{
            //    Console.WriteLine(n);
            //}

            //var result = from n in numbers
            //             //where n%2 == 0 && n > 3 && n < 8
            //             select n;
            //Console.WriteLine("Average: " + result.Average());
            //Console.WriteLine("Maximum: " + result.Max());
            //foreach (int n in result)
            //{
            //    Console.WriteLine(n);
            //}

            Console.ReadKey();
        }
    }
}
