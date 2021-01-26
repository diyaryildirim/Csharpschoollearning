using System;

namespace D28_ornek_bir_sayinin_faktoriyel_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            while (true)
            {
               
                Console.WriteLine("Lütfen faktöriyelini almak istediğiniz sayıyı giriniz.");
                sayi = int.Parse(Console.ReadLine());
                 //5 * 4 * 3 * 2 * 1
                int orijinalSayi = sayi;
                int sonuc = 1;
              if(sayi >= 0)
               {
               while (sayi>0)
                {
                sonuc *= sayi;
                sayi--;
                }

                Console.WriteLine(orijinalSayi + "! =" + sonuc);

               }
                else
                {
                    Console.WriteLine("Lütfen 0 veya 0'dan büyük bir sayi giriniz.");
                }
            }

            Console.ReadKey();
        }
    }
}
