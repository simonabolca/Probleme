using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care accepta de la utilizar doua numere, si afiseaza toate numerele intre ele. 
            //Daca primul numar e mai mic decat al doilea, numerele afisate vor fi in ordine crescatoare.
            //Daca primul numar e mai mare ca l doilea, numerele afisate for fi in ordine descrescatoare.
            //La problema precedenta, afisati doar fiecare al doilea numar.
            Console.WriteLine("Introduceti un numar");
            int primulNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inca un numar");
            int alDoileaNumar = int.Parse(Console.ReadLine());


            if (primulNumar < alDoileaNumar)
            {
                for (int i = primulNumar + 2 ; i < alDoileaNumar; i=i+2)
                {
                    Console.WriteLine(i + " ");
                }

            }


            if (primulNumar > alDoileaNumar)
            {

                for (int k = primulNumar - 2 ; k > alDoileaNumar; k=k-2)

                {
                    Console.WriteLine(k + " ");
                }

            }





            Console.ReadKey();
        }
    }
    }

