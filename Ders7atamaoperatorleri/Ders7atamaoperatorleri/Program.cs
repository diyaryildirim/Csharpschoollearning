using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7atamaoperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;

            Console.WriteLine(sayi);
            sayi = sayi + 3;
            Console.WriteLine(sayi);
            sayi += 3;
            Console.WriteLine(sayi);
            sayi = sayi - 3;
            Console.WriteLine(sayi);
            sayi -= 3;
            Console.WriteLine(sayi);

            double sayi2 = 10;

            Console.WriteLine(sayi2);
            sayi2 = sayi2 / 2;
            Console.WriteLine(sayi2);
            sayi2 /= 2;
            Console.WriteLine(sayi2);
            sayi2 = sayi2 * 2;
            Console.WriteLine(sayi2);
            sayi2 *= 2;
            Console.WriteLine(sayi2);
            sayi2 = sayi2 % 2;
            Console.WriteLine(sayi2);



            Console.ReadLine();

        }
    }
}
