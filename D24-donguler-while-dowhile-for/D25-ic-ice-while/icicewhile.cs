using System;

namespace D25_ic_ice_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 1;
            int sayi2 = 2;

            while (sayi1<=10)
            {
                while (sayi2 <= 10)
                {
                    Console.WriteLine(sayi1 + "*" + sayi2 + "=" + sayi1 * sayi2);
                    sayi2++;
                }


                sayi1++;
                sayi2 = 1;
            }




            Console.ReadLine();
        }
    }
}
