using System;

namespace D26_birden_Nekadar_olan_sayilarin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int kacakadar;
            int gercekkacakadar;
            Console.WriteLine("1den kaça kadar olan sayıları toplamak istiyorsunuz.");
            kacakadar = int.Parse(Console.ReadLine());

            gercekkacakadar = kacakadar;


            int toplam = 0;

            while (kacakadar>0)
            {
                toplam += kacakadar;
                kacakadar--;
            }

            Console.WriteLine("1-{0} arası sayıların toplamı {1}", gercekkacakadar, toplam);



            Console.ReadLine();
        }
    }
}
