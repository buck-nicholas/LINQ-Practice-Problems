using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeThree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            var gradeResults = classGrades.Select(x => x.Split(',')).Select(x => Array.ConvertAll(x, double.Parse)).Select(x => (x.Sum() - x.Min()) / (x.Count() - 1)).Average();

            Console.WriteLine(gradeResults);
            Console.ReadLine();
        }
    }
}
