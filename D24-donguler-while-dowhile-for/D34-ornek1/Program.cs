  using System;

namespace D34_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 1500 1 4 7 10 13 16
            int kacaKadar, aralik;

            Console.WriteLine("Lütfen kaça kadar yazdırmak istediğinizi giriniz");
            kacaKadar = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen yazdırmak istediğiniz aralığı giriniz");
            aralik = int.Parse(Console.ReadLine());

            for(int i = 1; i <= kacaKadar; i += aralik)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
