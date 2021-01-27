using System;

namespace D31_iki_sayi_ebob_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1.sayiyi giriniz.");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı Giriniz.");
            sayi2 = int.Parse(Console.ReadLine());
            int orjSayi1 = sayi1;
            int orjSayi2 = sayi2;

            sayi1 = (sayi1 < 0) ? -sayi1 : sayi1;
            sayi2 = (sayi2 < 0) ? -sayi2 : sayi2;

            while (sayi1 != sayi2)
            {
                if(sayi1 > sayi2)
                {
                    sayi1 -= sayi2;
                }
                else
                {
                    sayi2 -= sayi1;
                }

            }

            Console.WriteLine("EBOB ({0},{1}) = {2}", orjSayi1, orjSayi2, sayi1);

            Console.ReadLine();

        }
    }
}
