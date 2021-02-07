using System;

namespace D53_Diziler
{
    class Program
    {
        class Insan
        {
            public Insan (string Isim, int yas)
            {
                this.Isim = Isim;
                this.Yas = yas;
            }

            public string Isim { get; set; }
            public int Yas { get; set; }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan("Diyar Yıldırım", 21);
            Insan i2 = new Insan("Ahmet", 15);

            Insan[] insanlar = { i1, i2 };

            for (int i=0;i<insanlar.Length ; i++)
            {
                Console.WriteLine(insanlar[i],Isim + " " + insanlar[i].Yas);
            }

            /* int[] sayilar = new int[4]; // 1.oluşturma
             sayilar[0] = 10;
             sayilar[1] = 15;
             sayilar[2] = 20;
             sayilar[3] = 25;

             for(int i=0; i< sayilar.Length ; i++)
             {
                 Console.WriteLine(sayilar[i]);
             }*/

            /*int[] sayilar= new int[4] { 10, 20, 30, 40 }; //2.oluşturma*/


            /* int[] sayilar = { 100, 200, 300, 400 } //3.oluşturma */
            /*
            string[] isimler = { "C Programlama", "C++ Programlama", " C# Programlama" };

            for(int i=0; i< isimler.Length ; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            */

            Console.ReadLine();
        }
    }
}
