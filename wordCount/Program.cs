using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3JM
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int nrCuvinte = 0;
            bool a = false;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    a = false;
                }
                else
                {
                    if (!a) nrCuvinte++;
                    a = true;
                }

            }

            Console.WriteLine(nrCuvinte);
            Console.ReadLine();
        }
    }
}

