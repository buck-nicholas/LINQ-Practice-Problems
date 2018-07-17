using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var containsThInString = words.Where(str => str.Contains("th"));

            foreach(var str in containsThInString)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
