using System;

namespace D27_ornek_iki_sayi_arasindeki_sayilarin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1.sayıyı giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı giriniz");
            sayi2 = int.Parse(Console.ReadLine());
            int orijinalsayi = sayi1;
            int dongusayisi = sayi2 - sayi1 + 1;
            int toplam = 0;
            while (dongusayisi > 0)
            {
                toplam += sayi1;
                sayi1++;



                dongusayisi--;
            }

            Console.WriteLine("{0}-{1} sayıları arasındaki sayıların toplamı = {2}", orijinalsayi, sayi2, toplam);
            Console.ReadLine();




        }
    }
}
