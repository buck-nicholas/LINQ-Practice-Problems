using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that takes in a string of letters(i.e. “Terrill”) and 
            //returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")

            string someString = "Terrill";

            var newString = someString.ToUpper().GroupBy(x => x).Select(x => x.Key + "" + x.Count()).OrderBy(x => x).ToArray();

            StringBuilder newbuilder = new StringBuilder();
            foreach(string value in newString)
            {
                newbuilder.Append(value);
            }
            newbuilder.ToString();

            Console.WriteLine(newbuilder);
            Console.ReadLine();
        }
    }
}
