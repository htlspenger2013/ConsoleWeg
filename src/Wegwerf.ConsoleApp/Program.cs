using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wegwerf.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISet<int> set = new HashSet<int>();
            // unsinn
            Random r = new Random();
            while(set.Count < 10) {
                set.Add(r.Next(1, 21));
            }
            foreach (var item in set) {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
