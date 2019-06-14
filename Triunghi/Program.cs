using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triunghi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Scrietie o aplicatie in C# care primeste ca si argument o valoare si o distanta, tot ca si numar.
            //Afisati un triunghi cu latura echivalenta cu distanta introdusa.
            //Exemplu:
            //Numar: 6
            //Distanta: 6
            //666666
            //66666
            //6666
            //666
            //66
            //6



            Console.WriteLine("Scrie un numar");
            string numar = Console.ReadLine();
            

            Console.WriteLine("Scrie o distanta");
            string distantaString = Console.ReadLine();
            int distanta = int.Parse(distantaString);


            int i, j, k;
            for (i = 1; i <= distanta; i++)
            {
                for (j = 1; j <= distanta - i; j++)
                {
                    // Console.Write(" ");  
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write($"{numar}");
                }
                Console.WriteLine("");
            }



            Console.ReadKey();

        }
    }
}
