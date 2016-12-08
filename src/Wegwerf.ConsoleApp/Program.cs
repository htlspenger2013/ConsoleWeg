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
            // 
            ISet<int> set = new HashSet<int>();

            Random r = new Random();
            while(set.Count < 20) {
                set.Add(r.Next(1, 21));
            }
            foreach (var item in set) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
