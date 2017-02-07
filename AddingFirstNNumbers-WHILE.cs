using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingFirstNNumers_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int w = 0;
            int n;

            n = int.Parse(Console.ReadLine());
            while (i < n)
            {
                i = i + 1;
                w = w + i;

            }
            Console.Write(w);
            Console.ReadKey();
        }
    }
}
