using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatisticalAlgorithms;

namespace DebuggingConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Permutations p = new Permutations();
            List<string> perms = p.GetPermutations("abcd");
            foreach (var perm in perms)
            {
                Console.WriteLine(perm);
            }
            Console.ReadKey();
        }
    }
}
