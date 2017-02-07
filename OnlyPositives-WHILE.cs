using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyPositives_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Please enter a positive number:  ");
            n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.Write("Please enter a number grater than zero:  ");
                n = int.Parse(Console.ReadLine());

            }

            Console.Write("Wow finally... thank you for entering a positive number :v");
            Console.ReadKey();
        }
    }
}
