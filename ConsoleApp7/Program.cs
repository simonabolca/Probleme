using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salut");

            Console.WriteLine("care este prenumele tau?");
            string prenume = Console.ReadLine();

            Console.WriteLine("Care este numele tau?");
            string nume = Console.ReadLine();

            Console.WriteLine("Unde te-ai nascut?");
            string oras = Console.ReadLine();
            Afiseaza( prenume, nume, oras);

            ReverseString(prenume);
            ReverseString(nume);
            ReverseString(oras);
            Console.ReadKey();

        }
        static string  ReverseString(string intrare)
        {
            char[] iesire = intrare.ToArray();
            Array.Reverse(iesire);

            string result = " ";
            foreach(char item in iesire)
            {
                result += item;
                
            }
            Console.WriteLine(result);
                return result;
        }
        static void Afiseaza( string prenume, string nume, string oras)
        {
            Console.WriteLine($" Buna {prenume} {nume},nascuta in {oras} ");

        }
            
        }
    }

