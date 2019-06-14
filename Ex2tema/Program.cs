using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2tema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care accepta de la utilizar doua numere, si afiseaza toate numerele intre ele.
            //Daca primul numar e mai mic decat al doilea, numerele afisate vor fi in ordine crescatoare.
            //Daca primul numar e mai mare ca l doilea, numerele afisate for fi in ordine descrescatoare.
            Console.WriteLine("Introduceti un numar");
            int primulNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inca un numar");
            int alDoileaNumar = int.Parse(Console.ReadLine());

             
                if (primulNumar < alDoileaNumar)
                {
                for (int i =primulNumar+1; i < alDoileaNumar; i++)
                {
                    Console.WriteLine(i+" ");
                }
                    
                }


            if (primulNumar > alDoileaNumar)
            {

                for (int k = primulNumar - 1; k > alDoileaNumar; k--)

                {
                    Console.WriteLine(k + " ");
                }

            }
           
                

                
            
            Console.ReadKey();
        } 
        

    }
}
