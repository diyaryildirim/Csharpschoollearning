using System;

namespace D54_Foreach_Dongusu
{
    class Program
    {
        //Foreach Dongusu
        static void Main(string[] args)
        {
            int[] sayilar = { 2, 5, 3, 8, 9, 10, 15, 20, 25 };
            int toplam = 0;
            //string[] isimler = { "Diyar", "Mehmet", "Barış" };

            for(int i =0;i<sayilar.Length ;i++)
            {
                toplam += sayilar[i];
            }
            //Collection -> Koleksiyon
            /*foreach(var item in sayilar)
            {
               // Console.WriteLine(item);
               toplam += item;
            }*/

            Console.WriteLine(toplam);

            Console.ReadLine();
        }
    }
}
