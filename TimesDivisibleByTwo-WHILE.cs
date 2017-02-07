using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIn;
            int i = 0;
            double division;
            double reminder;

            Console.Write("Insert a number: ");
            numberIn = int.Parse(Console.ReadLine());

            division = numberIn / 2;
            reminder = numberIn % 2;

            if(reminder > 0)
            {
                Console.Write("\nThe number cannot be divided by 2");
            }
            else
            {
                i++;
                    while (reminder == 0)
                    {
                        i++;
                        division = division / 2;
                        reminder = division % 2;
                    }
                
                Console.Write("\nThe number of times it can be divisible by two are: {0}", i);
            }
            Console.ReadKey();
        }
    }
}
