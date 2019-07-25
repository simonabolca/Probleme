using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorCifreRomane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intre 1 si 3999");
            int numar = int.Parse(Console.ReadLine());
            Console.WriteLine(Converteste(numar));
            Console.ReadLine();
        }
        private static  string Converteste(int numar)
        {
            if (numar < 0 || numar > 3999) throw new ArgumentOutOfRangeException("Alegeti un numar pozitiv pana la 3999");
            if (numar < 1) return string.Empty;
            if (numar >= 1000) return "M" + Converteste(numar - 1000);
            if (numar >= 900) return "CM" + Converteste(numar - 900);
            if (numar >= 500) return "D" + Converteste(numar - 500);
            if (numar >= 400) return "CD" + Converteste(numar - 400);
            if (numar >= 100) return "C" + Converteste(numar - 100);
            if (numar >= 90) return "XC" + Converteste(numar - 90);
            if (numar >= 50) return "L" + Converteste(numar - 50);
            if (numar >= 40) return "XL" + Converteste(numar - 40);
            if (numar >= 10) return "X" + Converteste(numar - 10);
            if (numar == 9) return "IX";
            if (numar >= 5) return "V" + Converteste(numar - 5);
            if (numar == 4) return "IV";
            if (numar >= 1) return "I" + Converteste(numar - 1);
            throw new ArgumentOutOfRangeException("alt numar");
        }
    }
}
