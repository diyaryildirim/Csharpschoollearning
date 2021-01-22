using System;

namespace ders14sayıdegeridegisme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;

            Console.WriteLine("Lütfen 1. Sayıyı giriniz. ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı giriniz.");
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1. sayı = {0} \n 2. sayı = {1} ", sayi1, sayi2);

            int temp;
            // SWAP değitirme
            temp = sayi1;
            sayi1 = sayi2;
            sayi2 = temp;

            Console.WriteLine("1. sayı = {0} 2. sayı = {1} ", sayi1, sayi2);


            Console.ReadLine();
        }
    }
}
