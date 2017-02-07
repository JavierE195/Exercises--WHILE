using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesOrNo_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            bool s = true;
            string w;
           
            Console.Write("Does your parents know that you're gay?: ");
            w = (Console.ReadLine());
            if (w == "Y" || w == "YES" || w == "Yes" || w == "yes" || w == "y" || w == "N" || w == "NO" || w == "No" || w == "no" || w == "n")
            {
                s = false;
            }

            while (s == true ) 
            {
                Console.Write("Please give an honest answer: ");
                w = (Console.ReadLine());
                if (w == "Y" || w == "YES" || w == "Yes" || w == "yes" || w == "y" || w == "N" || w == "NO" || w == "No" || w == "no" || w == "n")
                {
                    s = false;
                }

            }
            Console.Write("See? it wasn't that hard");
            Console.ReadKey();
        }
    }
}
