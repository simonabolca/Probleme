using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrPrim
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Afisati la consola numerele prime pana la 100.
            Console.WriteLine("Primele 100 de numere prime sunt:");


            
            for (int i = 2; i < 100; i++)
            {
                if (i == 2 || i == 3 || i == 5)
                {
                    Console.Write(i + "  ");
                }
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i + "  ");
                }

            }
           
            Console.ReadLine();
            
                
                
            
                    
            
            
            }


        



        

            


        
            
        
               


        }
} 

     
                
            
            

        

    

