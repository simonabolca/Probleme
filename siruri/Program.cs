using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Intoroduceti un sir de numere");

            int sir = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),arrTemp=>int.Parse(arrTemp));

            int t;
            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = 0; j < arr.Length-2; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
                
            }
            foreach(int nr in arr)
            {
                Console.WriteLine(nr + " ");
            }
            Console.ReadKey();
        }

    }
}
