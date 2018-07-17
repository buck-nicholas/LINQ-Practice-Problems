using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

            var newList = names.GroupBy(x => x).Select(x => x.First());

            foreach (var name in newList)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
