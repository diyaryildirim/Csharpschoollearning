using System;

namespace D41_bos_donduren_parametreli_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            string isimSoyisim;
            int yas;
            double boy;

            Console.WriteLine("Lütfen isminizi ve soyisminizi giriniz");
            isimSoyisim = Console.ReadLine();
            Console.WriteLine("Lütfen yaşınızı giriniz.");
            yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz.");
            boy = double.Parse(Console.ReadLine());

            bilgileriGoster(isimSoyisim, yas, boy);
            dogumYiliHesapla(yas);

            Console.ReadLine();
        }
        static void bilgileriGoster(string i, int y, double b)
        {
            Console.WriteLine("Adı ve Soyadı: {0}  Yaşınız : {1}  Boyunuz: {2}",i , y, b);
        }

        static void dogumYiliHesapla(int yas)
        {
            Console.WriteLine("Doğum tarhiniz:" + (2021 - yas));
        }
    }
}
