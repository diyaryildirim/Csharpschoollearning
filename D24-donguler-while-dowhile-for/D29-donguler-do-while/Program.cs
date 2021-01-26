using System;

namespace D29_donguler_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
            int toplam = 0;

            do
            {
                toplam += sayi;
                sayi--;
            } while (sayi > 0);

            Console.WriteLine(toplam);

            Console.ReadLine();

        }
    }
}
