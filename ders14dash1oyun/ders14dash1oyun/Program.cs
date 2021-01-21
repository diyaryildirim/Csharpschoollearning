using System;

namespace ders14dash1oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam, puan = 0, dogruCevapSayisi = 0,yanlisCevapSayisi = 0;
            char devamMi;
            do
            {
                Random rastgele = new Random();
                int sayi1 = rastgele.Next(1, 101);
                int sayi2 = rastgele.Next(1, 101);
                toplam = sayi1 + sayi2;
                Console.WriteLine("Tutulan 1.sayı : " + sayi1 + "\n Tututlan 2.sayı : " + sayi2);
                Console.WriteLine("Bu sayıların toplamı nedir ?");
                int kullaniciToplam = int.Parse(Console.ReadLine());
                if (kullaniciToplam == toplam)
                {
                    dogruCevapSayisi++;
                    puan += 5;
                    Console.WriteLine("Tebrikler Bildiniz!");
                }
                else
                {
                    yanlisCevapSayisi++;
                    puan -= 2;
                    Console.WriteLine("Üzgünüm Yanlış cevap");
                }

                Console.WriteLine("Tekrar Oynamak ister misiniz?(e/E)");
                devamMi = char.Parse(Console.ReadLine());

            } while (devamMi == 'e' || devamMi == 'E');

            Console.WriteLine("Doğru cevap sayısı : {0}", dogruCevapSayisi);
            Console.WriteLine("Yanlış cevap sayısı : {0}", yanlisCevapSayisi);
            Console.WriteLine("Toplam Puanınız : {0}", puan);

            Console.ReadLine();
        }
    }
}
