using System;

namespace D32_girilen_sayiyi_tersten_yazma
{
    class Program
    {
        static void Main(string[] args)
        {
            //152  251
                int sayi;
                int sayininTersi = 0;
                    Console.WriteLine("Lütfen Bir Sayıyı giriniz.");
                     sayi = Convert.ToInt32(Console.ReadLine());
                int orjSayi = sayi;
                do
                {

                    sayininTersi *= 10;
                    sayininTersi += sayi % 10;
                    sayi /= 10;

                } while (sayi != 0);


                Console.WriteLine(orjSayi + "Sayısının tersten yazılmış hali :" + sayininTersi);
                Console.ReadLine();

        }
    }
}
