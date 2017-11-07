using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6A
{
    class Debugging
    {
        static void Main()
        {
            Debugging db = new Debugging();
            db.LetterCounter(null, null);
            
            Console.ReadKey();
        }

        public void LetterCounter(string strText, string letterToCount)
        {
            if (strText != null)
            {
                int LetterCount = 0;
                //string strText = "Debugging";
                string letter;

                for (int i = 0; i < strText.Length; i++)
                {
                    letter = strText.Substring(i, 1);

                    if (letter == letterToCount)
                        LetterCount++;
                }

                Console.WriteLine(letterToCount + " appears " + LetterCount + " times");
            }
        }

        public void parse(String str, String check)
        {
            
        }
    }
}
