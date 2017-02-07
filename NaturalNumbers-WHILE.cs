using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n;

            n = int.Parse(Console.ReadLine());
            while (i < n)
            {
                i = i + 1;
                Console.Write("[{0}] ",i);
       
            }

            Console.ReadKey();
        }
    }
}
