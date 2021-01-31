using System;

namespace D42_donus_degerine_sahip_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(hesapla(8,9));
            Console.WriteLine(buyukSayiBul(45, 68));
            */
            string kullaniciIfadesi;
            Console.WriteLine("Sizde anahtar var mı ? Varsa 'VAR' yazın");
            kullaniciIfadesi = Console.ReadLine();

            if (anatarVarMi(kullaniciIfadesi))
            {
                Console.WriteLine("içeri girebilirsiniz.");
            }
            else
            {
                Console.WriteLine("İçeri GİREMEZSİNZ!!!");
            }

            Console.ReadLine();
        }
        static bool anatarVarMi(string ifade)
        {
            if (ifade == "Var"; ifade == "VAR")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double buyukSayiBul(double s1, double s2)
        {
            if (s1 > s2)
            {
                return s1;
            }
            else
            {
                return s2;
            }
        }



        static int hesapla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
