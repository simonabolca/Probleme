using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrie o propozitie.");

            string propozitie = Console.ReadLine();

            int nrCuvinte = 0;

            for (int i = 1; i < propozitie.Length; i++)
            {
                if (char.IsWhiteSpace(propozitie[i - 1]) == true)
                {
                    if (char.IsLetter(propozitie[i])==true )// || char.IsPunctuation(propozitie[i]))
                    {
                        nrCuvinte++;

                    }

                }
            }
            if (propozitie.Length>2)
            {
                nrCuvinte++;
            }


            Console.WriteLine($"Numarul de cuvinte din propozitia ta este: {nrCuvinte}");
            Console.ReadKey();

        }

    }
}
