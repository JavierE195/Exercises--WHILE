using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            while (0 < n)
            {
                Console.Write("[{0}]", n);
                n = n - 1;
            }
            Console.ReadKey();
        }
    }
}
